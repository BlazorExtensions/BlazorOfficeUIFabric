TOP=$(realpath $(CURDIR)/../..)

#Use either 'release' or 'debug' dependending on what you need
DRIVER_CONF=release

#Use either 'release' or 'debug' dependending on what you need
DOM_CONF=debug

WASM_BCL_DIR=$(TOP)/mono/sdks/bcl
DEPLOY_DIR=$(TOP)/mono
MANAGED_DEPLOY_DIR=$(TOP)/mono/sdks/bcl
MANAGED_WASM_DOM_DIR=$(TOP)/Mono.WebAssembly.Browser/bin/$(DOM_CONF)

BCL_ASSEMBLIES= \
        mscorlib.dll    \
        System.dll      \
        System.Core.dll \


APP_SOURCES = \
	./DOMElement.cs  \
	./ElementTinkerer.cs

MANAGED_ASSEMBLIES= \
        Mono.WebAssembly.Browser.dll

TEST_DEPS = $(patsubst %,managed/%,$(BCL_ASSEMBLIES))
TEST_CSC_DEPS = $(patsubst %,-r:%, $(TEST_DEPS))

MANAGED_DEPS = $(patsubst %,$(MANAGED_WASM_DOM_DIR)/%,$(MANAGED_ASSEMBLIES))
MANAGED_CSC_DEPS = $(patsubst %,-r:%, $(MANAGED_DEPS))

publish/:
	mkdir -p $@

managed/:
	mkdir -p $@

$(patsubst %,managed/%,$(BCL_ASSEMBLIES)): managed/%: $(WASM_BCL_DIR)/% | managed/
	cp $< $@

$(patsubst %,managed/%,$(MANAGED_ASSEMBLIES)): managed/%: $(MANAGED_DEPLOY_DIR)/% | managed/
	cp $< $@

managed/DOMElement.dll: $(TEST_DEPS) $(MANAGED_DEPS) $(APP_SOURCES) | managed/
	csc /debug:portable /noconfig /nostdlib /unsafe /nowarn:1701,1702,2008 /target:library -out:$@ $(TEST_CSC_DEPS) $(MANAGED_CSC_DEPS) $(APP_SOURCES)

build-managed: managed/DOMElement.dll

build: build-managed
	rm -rf publish
	mkdir publish
	mkdir publish/bcl
	cp -r $(WASM_BCL_DIR)/* publish/bcl/
	cp $(DEPLOY_DIR)/$(DRIVER_CONF)/* publish/
	cp $(MANAGED_DEPS) managed
	cp -r managed publish/
	cp $(MANAGED_WASM_DOM_DIR)/mono-wasm-browser.js publish/
	cp index.html publish/
	cp -r sections publish/
	cp $(TOP)/samples/sample_module.js publish/
	cp $(DEPLOY_DIR)/sdks/server.py publish/

clean:
	rm -rf managed publish