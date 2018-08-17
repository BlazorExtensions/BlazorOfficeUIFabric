


# Tinkering with HTML DOM Elements

Example of tinkering with HTML DOM Elements.  Uses HTML 5 imports via the `HTMLLinkElement` Import method to dynamically modify the DOM content.

This may not work with [FireFox](https://developer.mozilla.org/en-US/docs/Web/Web_Components/HTML_Imports).

## Features

* [HTML 5 Imports specs](http://w3c.github.io/webcomponents/spec/imports/)

* Other reference links
  - [WebComponents.org introduction](https://www.webcomponents.org/community/articles/introduction-to-html-imports)
  - [html5rocks.com tutorial](https://www.html5rocks.com/en/tutorials/webcomponents/imports/)
  - [teamtreehouse.com introduction](http://blog.teamtreehouse.com/introduction-html-imports)

## Prerequisits

A built `Mono.WebAssembly.DOM` assembly.

## Building 

Right now the following targets are available:

- build: Sets up the libraries, copies the binaries required from the dom-wasm directory and then builds the sample DOMElement sources.
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

