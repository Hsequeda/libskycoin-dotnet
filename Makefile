PWD = $(shell pwd)
GOPATH_DIR = $(PWD)/gopath
SKYCOIN_DIR = gopath/src/github.com/skycoin/skycoin
SKYBUILD_DIR = $(SKYCOIN_DIR)/build
BUILDLIBC_DIR = $(SKYBUILD_DIR)/libskycoin
LIBC_DIR = $(SKYCOIN_DIR)/lib/cgo
LIBSWIG_DIR = lib/swig
BUILD_DIR = build
BIN_DIR = $(SKYCOIN_DIR)/bin
INCLUDE_DIR = $(SKYCOIN_DIR)/include
FULL_PATH_LIB = $(PWD)/$(BUILDLIBC_DIR)

LIB_FILES = $(shell find $(SKYCOIN_DIR)/lib/cgo -type f -name "*.go")
SRC_FILES = $(shell find $(SKYCOIN_DIR)/src -type f -name "*.go")
SWIG_FILES = $(shell find $(LIBSWIG_DIR) -type f -name "*.i")
HEADER_FILES = $(shell find $(SKYCOIN_DIR)/include -type f -name "*.h")

# Added by Swagger
LIB_SKYCOIN_DIR = gopath/src/github.com/skycoin/libskycoin
SWAGGER_SPEC_DIR = $(LIB_SKYCOIN_DIR)/lib/swagger/skycoin.v0.25.1.openapi.v2.yml
CSHARP_CLIENT_DIR = lib/restsharp

CSHARP_SWIG_DIR = lib/swig

configure: ## Setup build environment
	mkdir -p $(BUILD_DIR)/usr/tmp $(BUILD_DIR)/usr/lib $(BUILD_DIR)/usr/include
	mkdir -p $(BUILDLIBC_DIR) $(BIN_DIR) $(INCLUDE_DIR)

$(BUILDLIBC_DIR)/libskycoin.a: $(LIB_FILES) $(SRC_FILES) $(HEADER_FILES)
	rm -f $(BUILDLIBC_DIR)/libskycoin.a
	GOPATH="$(GOPATH_DIR)" make -C $(SKYCOIN_DIR) build-libc-static
	ls $(BUILDLIBC_DIR)
	rm -f lib/swig/include/libskycoin.h
	mkdir -p lib/swig/include
	grep -v "_Complex" $(INCLUDE_DIR)/libskycoin.h > lib/swig/include/libskycoin.h

build-libc: configure $(BUILDLIBC_DIR)/libskycoin.a ## Build libskycoin static C client library

build-swig: ## Generate csharp source code from SWIG interface definitions
	#Generate structs.i from skytypes.gen.h
	rm -f $(LIBSWIG_DIR)/structs.i
	cp $(INCLUDE_DIR)/skytypes.gen.h $(LIBSWIG_DIR)/structs.i
	#sed -i 's/#/%/g' $(LIBSWIG_DIR)/structs.i
	{ \
		if [[ "$$(uname -s)" == "Darwin" ]]; then \
			sed -i '.kbk' 's/#/%/g' $(LIBSWIG_DIR)/structs.i ;\
		else \
			sed -i 's/#/%/g' $(LIBSWIG_DIR)/structs.i ;\
		fi \
	}
	mkdir -p $(CSHARP_SWIG_DIR)/LibskycoinNet/skycoin
	rm -f $(LIBSWIG_DIR)/swig/include/swig.h
	rm -f $(CSHARP_SWIG_DIR)/LibskycoinNet/skycoin/skycoinnet_wrap.c
	swig -csharp -oldvarnames -v -namespace  skycoin -Iswig/include -I$(INCLUDE_DIR) -outdir $(CSHARP_SWIG_DIR)/LibskycoinNet/skycoin -o $(CSHARP_SWIG_DIR)/LibskycoinNet/skycoin/skycoinnet_wrap.c $(LIBSWIG_DIR)/libdotnet.i
	
build-libskycoin-net:	build-swig build-libc ## Build shared library including SWIG wrappers
	gcc -c -fpic -ILibskycoinNet/swig/include -I$(INCLUDE_DIR) $(CSHARP_SWIG_DIR)/LibskycoinNet/skycoin/skycoinnet_wrap.c
	gcc -shared skycoinnet_wrap.o $(BUILDLIBC_DIR)/libskycoin.a -o libskycoin.so
	mv libskycoin.so $(CSHARP_SWIG_DIR)/LibskycoinNetTest/bin/Release

install-deps: ## Install development dependencies
	/bin/sh $(CSHARP_CLIENT_DIR)/build.sh
	nuget restore $(CSHARP_SWIG_DIR)/LibskycoinNet.sln
	nuget install NUnit.Runners -Version 2.6.4 -OutputDirectory testrunner

build-sln: install-deps build-libc build-swig
	msbuild /p:Configuration=Release $(CSHARP_SWIG_DIR)/LibskycoinNet.sln
	msbuild /p:Configuration=Debug $(CSHARP_SWIG_DIR)/LibskycoinNet.sln

build: build-sln build-libskycoin-net ## Build LibSkycoinNet Assembly

test: build ## Run LibSkycoinNet test suite
#	mono ./testrunner/NUnit.Runners.2.6.4/tools/nunit-console.exe $(CSHARP_SWIG_DIR)/LibskycoinNetTest/bin/Release/LibskycoinNetTest.dll -labels

help:
	@grep -E '^[a-zA-Z_-]+:.*?## .*$$' $(MAKEFILE_LIST) | awk 'BEGIN {FS = ":.*?## "}; {printf "\033[36m%-30s\033[0m %s\n", $$1, $$2}'
