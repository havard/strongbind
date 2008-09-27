@echo off

pushd %~dp0

..\OX.Strongbind.TestGenerator\bin\Debug\OX.Strongbind.TestGenerator.exe %~dp0\GeneratedBindingTests.cs

popd