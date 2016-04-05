@echo off
SETLOCAL

cls

cd ..
cd src/

.paket\paket.bootstrapper.exe
if errorlevel 1 (
  exit /b %errorlevel%
)

.paket\paket.exe restore
if errorlevel 1 (
  exit /b %errorlevel%
)

SET FAKE_PATH=packages\FAKE\tools\Fake.exe

IF [%1]==[] (
    "%FAKE_PATH%" "..\scripts\build.fsx" "Default" 
) ELSE (
    "%FAKE_PATH%" "..\scripts\build.fsx" %* 
) 