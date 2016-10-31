#!/bin/bash
export NUGET_PACKAGES=./packages
dotnet restore
dotnet build