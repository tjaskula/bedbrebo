#!/bin/bash
if test "$OS" = "Windows_NT"
then
  # use .Net

  ../src/.paket/paket.bootstrapper.exe
  exit_code=$?
  if [ $exit_code -ne 0 ]; then
  	exit $exit_code
  fi

  ../src/.paket/paket.exe restore
  exit_code=$?
  if [ $exit_code -ne 0 ]; then
  	exit $exit_code
  fi
  
  [ ! -e build.fsx ] && ../src/.paket/paket.exe update
  [ ! -e build.fsx ] && ../src/packages/FAKE/tools/FAKE.exe init.fsx
  ../src/packages/FAKE/tools/FAKE.exe $@ --fsiargs -d:MONO build.fsx 
else
  # use mono
  mono ../src/.paket/paket.bootstrapper.exe
  exit_code=$?
  if [ $exit_code -ne 0 ]; then
  	exit $exit_code
  fi

  mono ../src/.paket/paket.exe restore
  exit_code=$?
  if [ $exit_code -ne 0 ]; then
  	exit $exit_code
  fi

  [ ! -e build.fsx ] && mono ../src/.paket/paket.exe update
  [ ! -e build.fsx ] && mono ../src/packages/FAKE/tools/FAKE.exe init.fsx
  mono ../src/packages/FAKE/tools/FAKE.exe $@ --fsiargs -d:MONO build.fsx 
fi