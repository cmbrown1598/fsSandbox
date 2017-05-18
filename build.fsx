// include Fake libs
#r "./packages/FAKE/tools/FakeLib.dll"

open Fake
open Fake.Testing.NUnit3

RestorePackages()

// Filesets
let appReferences  =
    !! "/**/*.fsproj"

// version info
let version = "0.1"  // or retrieve from CI server

// Targets

Target "Build" (fun _ ->
    // compile all projects below src/app/
    appReferences
    |> MSBuildRelease "" "Rebuild" 
    |> ignore
)

Target "Test" (fun _ ->
    // compile all projects below src/app/
    !! "**/test/bin/Release/*test.dll"
    |> NUnit3 id 
    |> ignore
)

"Build" ==> "Test"
// start build
RunTargetOrDefault "Build"
