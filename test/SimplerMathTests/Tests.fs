module Tests

open Xunit
open SimplerMath
open FsUnit.Xunit

[<Fact>]
let ``Integer divided by Integer is Float`` () =
  1 .div 2 |> should equal 0.5

[<Fact>]
let ``Integer divided by Long is Float`` () =
  1 .div 2L |> should equal 0.5

[<Fact>]
let ``Integer divided by Float is Float`` () =
  1 .div 2.0 |> should equal 0.5

[<Fact>]
let ``Long divided by Integer is Float`` () =
  1L .div 4 |> should equal 0.25

[<Fact>]
let ``Long divided by Long is Float`` () =
  1L .div 4L |> should equal 0.25

[<Fact>]
let ``Long divided by Float is Float`` () =
  1L .div 4.0 |> should equal 0.25

[<Fact>]
let ``Float divided by Float is Float`` () =
  1.0 .div 8.0 |> should equal 0.125

[<Fact>]
let ``Float divided by Integer is Float`` () =
  1.0 .div 8 |> should equal 0.125

[<Fact>]
let ``Float divided by Long is Float`` () =
  1.0 .div 8L |> should equal 0.125
