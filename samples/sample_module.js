var Module = {

    print: function(x) { if (this.mono_wasm_debug) console.log ("WASM-DOM: " + x) },
    printErr: function(x) { if (this.mono_wasm_debug) console.log ("WASM-DOM-ERR: " + x) },
    startLoadTime: Date.now(),
    runtimeLoadTime: null,
    bclLoadTime: null,
    onWasmDOMInitialized: [],
    onWasmDOMStarted: [],
    mono_wasm_debug : false,
    applicationAssemblies: [],
    defaultBclLibraries: ["mscorlib.dll", "System.dll", "System.Core.dll"],
    onRuntimeInitialized: function ()
    {
        //MonoDOMRuntime.onRuntimeInitialized();
        if (this.onWasmDOMInitialized) {
            if (typeof this.onWasmDOMInitialized == 'function') this.onWasmDOMInitialized = [this.onWasmDOMInitialized];
            while (this.onWasmDOMInitialized.length) {
                this.onWasmDOMInitialized.shift()();
            }
        }           
    },
    onBclLoaded: function () {
        Module.print ("Done loading the BCL.");
        
        
        this.load_runtime ("managed", 1);

        Module.print ("Done initializing the runtime.");

        if (this.onWasmDOMStarted) {
            if (typeof this.onWasmDOMStarted == 'function') this.onWasmDOMStarted = [this.onWasmDOMStarted];
            while (this.onWasmDOMStarted.length) {
                this.onWasmDOMStarted.shift()();
            }
        }                  
        
    },  
    runMainClass: function (assembly, name_Space, name, entryPoint, args)
    {

        // Initialize the browser assembly
        MonoWasmBrowserAPI.mono_wasm_browser_init();

        this.app_Assembly = this.assembly_load (assembly);
        if (!this.app_Assembly)
            throw "Could not find assembly: " + assembly;

        this.main_class = this.find_class (this.app_Assembly, name_Space, name);
        if (!this.main_class)
            throw "Could not find: " + name_Space + "." + name + " in: " + assembly;

        this.main_invoke = this.find_method (this.main_class, entryPoint, -1);
        if (!this.main_invoke)
            throw "Could not find: " + entryPoint + " in: " + nameSpace + "." + name;
        

        if (typeof args === 'undefined')
        {
            args = [0];
        }
        else
        {
            var tempArgs;
            if (typeof args === 'string' || args instanceof String)
                tempArgs = args;
            else
            {
                tempArgs = JSON.stringify(args);
            }
            args = [this.mono_string(tempArgs)];
        }

        var res = this.call_method (this.main_invoke, null, args);
        return this.conv_string (res);
    },
    conv_string: function (mono_obj) {
        if (mono_obj == 0)
            return null;
        var raw = this.mono_string_get_utf8 (mono_obj);
        var res = Module.UTF8ToString (raw);
        Module._free (raw);

        return res;
    },        
    call_method: function (method, this_arg, args) {
        var args_mem = Module._malloc (args.length * 4);
        var eh_throw = Module._malloc (4);
        for (var i = 0; i < args.length; ++i)
            Module.setValue (args_mem + i * 4, args [i], "i32");
        Module.setValue (eh_throw, 0, "i32");

        var res = this.invoke_method (method, this_arg, args_mem, eh_throw);

        var eh_res = Module.getValue (eh_throw, "i32");

        Module._free (args_mem);
        Module._free (eh_throw);

        if (eh_res != 0) {
            var msg = this.conv_string (res);
            throw new Error (msg);
        }

        return res;
    },    
};

Module["preRun"] = [];
Module["postRun"] = [];

// override the preRun
Module['preRun'].push(function() {

    Module.print('preRun');

    // it is ok to call cwrap before the runtime is loaded. we don't need the code
    // and everything to be ready, since cwrap just prepares to call code, it 
    // doesn't actually call it
    Module.load_runtime = Module.cwrap ('mono_wasm_load_runtime', null, ['string'])
    Module.assembly_load = Module.cwrap ('mono_wasm_assembly_load', 'number', ['string'])
    Module.find_class = Module.cwrap ('mono_wasm_assembly_find_class', 'number', ['number', 'string', 'string'])
    Module.find_method = Module.cwrap ('mono_wasm_assembly_find_method', 'number', ['number', 'string', 'number'])
    Module.invoke_method = Module.cwrap ('mono_wasm_invoke_method', 'number', ['number', 'number', 'number'])
    Module.mono_string_get_utf8 = Module.cwrap ('mono_wasm_string_get_utf8', 'number', ['number'])
    Module.mono_string = Module.cwrap ('mono_wasm_string_from_js', 'number', ['string'])

    
});

// override the postRun
Module['postRun'].push(function() {

    Module.print ("postRun");

    Module.runtimeLoadTime = Date.now ();
    Module.print ("Done with WASM module instantiation. Took " + (Module.runtimeLoadTime - Module.startLoadTime) + " ms");

    Module.FS_createPath ("/", "managed", true, true);

    var pending = 0;
    var runAssemblies = Module.defaultBclLibraries;
    runAssemblies.push(MonoWasmBrowserAPI.mono_wasm_browser_assembly())
    if (Module.applicationAssemblies) {
        runAssemblies = runAssemblies.concat(Module.applicationAssemblies);
    }


    runAssemblies.forEach (function(asm_name) {
        Module.print ("loading " + asm_name);
        ++pending;
        fetch ("managed/" + asm_name, { credentials: 'same-origin' }).then (function (response) {
            if (!response.ok)
                throw "failed to load Assembly '" + asm_name + "'";
            return response['arrayBuffer']();
        }).then (function (blob) {
            var asm = new Uint8Array (blob);
            Module.FS_createDataFile ("managed/" + asm_name, null, asm, true, true, true);
            Module.print ("LOADED: " + asm_name);
            --pending;
            if (pending == 0)
                Module.onBclLoaded ();
        });
    });

});