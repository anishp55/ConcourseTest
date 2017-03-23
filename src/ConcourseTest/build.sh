#!/bin/bash
rm -rf ./packages
mkdir ./packages
export NUGET_PACKAGES="`pwd`/packages"
dotnet restore
dotnet build