#!/usr/bin/env bash
#
# Generated by: https://github.com/openapitools/openapi-generator.git
#

wget -nc https://dist.nuget.org/win-x86-commandline/latest/nuget.exe
cert-sync --sync

echo "[INFO] remove bin/Debug/Skyapi.Test.dll"
rm src/Skyapi.Test/bin/Debug/Skyapi.Test.dll 2> /dev/null

echo "[INFO] install NUnit runners via NuGet"
wget -nc https://dist.nuget.org/win-x86-commandline/latest/nuget.exe
cert-sync --sync
mono nuget.exe install src/Skyapi.Test/packages.config -o packages

echo "[INFO] Install NUnit runners via NuGet"
mono nuget.exe install NUnit.Runners -Version 2.6.4 -OutputDirectory packages 

echo "[INFO] Build the solution and run the unit test"
msbuild Skyapi.sln && \
    mono ./packages/NUnit.Runners.2.6.4/tools/nunit-console.exe src/Skyapi.Test/bin/Debug/Skyapi.Test.dll
