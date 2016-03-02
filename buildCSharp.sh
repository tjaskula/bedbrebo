#!/bin/bash
if test "$OS" = "Windows_NT"
then
  # use .Net

  CSharp/.paket/paket.bootstrapper.exe
  exit_code=$?
  if [ $exit_code -ne 0 ]; then
  	exit $exit_code
  fi

  CSharp/.paket/paket.exe restore
  exit_code=$?
  if [ $exit_code -ne 0 ]; then
  	exit $exit_code
  fi
  
  [ ! -e build.fsx ] && CSharp/.paket/paket.exe update
  [ ! -e build.fsx ] && CSharp/packages/FAKE/tools/FAKE.exe init.fsx
  CSharp/packages/FAKE/tools/FAKE.exe $@ --fsiargs -d:MONO CSharp/build.fsx 
else
  # use mono
  mono CSharp/.paket/paket.bootstrapper.exe
  exit_code=$?
  if [ $exit_code -ne 0 ]; then
  	exit $exit_code
  fi

  mono CSharp/.paket/paket.exe restore
  exit_code=$?
  if [ $exit_code -ne 0 ]; then
  	exit $exit_code
  fi

  [ ! -e build.fsx ] && mono CSharp/.paket/paket.exe update
  [ ! -e build.fsx ] && mono CSharp/packages/FAKE/tools/FAKE.exe init.fsx
  mono CSharp/packages/FAKE/tools/FAKE.exe $@ --fsiargs -d:MONO CSharp/build.fsx 
fi