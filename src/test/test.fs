module Test

open Sandbox
open NUnit.Framework

[<Test>]
let ``Example Test`` () =
    Assert.AreEqual(1, 1)

[<Test>]
let ``Addition should add two numbers`` () =
    let result = addition 2 4
    Assert.AreEqual(6, result)

[<Test>]
let ``Addition should add two numbers well`` () =
    let result = addition 2 6
    Assert.AreEqual(7, result)    