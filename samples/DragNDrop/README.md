# CreateElement

This creates a new <div> and inserts it before the element with the ID "div1".

## Features

- Use of `CreateElement`
- Use of `CreateTextNode`
- Use of `AppendChild` and `InsertBefore`

## Prerequisits

A built `Mono.WebAssembly.DOM` assembly.

## Building 

Right now the following targets are available:

- build: Sets up the libraries, copies the binaries required from the dom-wasm directory and then builds the sample CreateElement.
- clean: Cleans up the libraries so that the build will rebuild all targets.

```
$ make build
```

When the sample code is finished building all the required code to run the sample is made available in the `publish` directory.

Once that's done, Start a web server from the `publish` directory:

```
publish$ python -m SimpleHTTPServer
```

Unfortunately, the above http server doesn't give wasm binaries the right mime type, which disables WebAssembly stream compilation.
The included `server.py` script from the `wasm` directory solves this and can be used instead.

```
publish$ python server.py
```


Go to `locahost:8000/index.html` and it should work.


