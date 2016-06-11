﻿// sets the current directory to be same as the script directory
System.IO.Directory.SetCurrentDirectory (__SOURCE_DIRECTORY__ + "/../src")

#I "../src/packages/FAKE/tools/"
#r "FakeLib.dll"
#r "System.Configuration.dll"

open Fake
open Fake.Testing

open System

let authors = ["bedbrebo.com"]

// project name and description
let projectName = "Bedbrebo"
let projectDescription = "Web portal bedbrebo.com that allows users to book a B&B room available in the BedBreBo catalog"
let projectSummary = "Bedbrebo, online catalog of B&B rent offers."

// directories
let buildDir = "./build/"
let testDir = "./Domain/BedBrebo.Domain.Bookings.UnitTests"

let buildMode = getBuildParamOrDefault "buildMode" "Release"

MSBuildDefaults <- { 
    MSBuildDefaults with 
        ToolsVersion = Some "14.0"
        Verbosity = Some MSBuildVerbosity.Minimal }

Target "Clean" (fun _ ->
    CleanDirs [buildDir]
)

let setParams defaults = {
    defaults with
        ToolsVersion = Some("14.0")
        Targets = ["Build"]
        Properties =
            [
                "Configuration", buildMode
            ]
    }

// define test dlls
let testDlls = !! (testDir + "/*UnitTest.dll")

Target "xUnitTest" (fun _ ->
    tracefn "Running tests..."
    testDlls
    |> xUnit2 (fun p -> 
        {p with 
            HtmlOutputPath = Some(testDir @@ "xunit.html")
            ToolPath = @"../packages/xunit.runner.console.2.0.0/tools/xunit.console.exe"})
)

Target "RestorePackages" (fun _ -> 
     "./bedbrebo.sln"
     |> RestoreMSSolutionPackages (fun p ->
         { p with
             Sources = "https://www.nuget.org/api/v2" :: p.Sources
             OutputPath = "./packages"
             Retries = 4 })
 )

Target "BuildApp" (fun _ ->
    build setParams "./bedbrebo.sln"
)

Target "BuildApp45" (fun _ ->
    build (fun p -> let defaults = setParams p
                    {defaults with 
                                ToolsVersion = Some("12.0") 
                                Properties = ["TargetFrameworkVersion", "v4.5"]}) "./bedbrebo.sln"
)

Target "Default" DoNothing

"Clean"
   ==> "BuildApp"

"RestorePackages"
    ==> "xUnitTest"
    ==> "BuildApp"

"RestorePackages"
    ==> "xUnitTest"
    ==> "BuildApp45"

"BuildApp"
   ==> "Default"

"BuildApp45"
   ==> "Default"

RunTargetOrDefault "BuildApp"