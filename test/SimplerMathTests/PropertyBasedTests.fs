module PropertyBasedTests

open Xunit
open SimplerMath
open FsUnit.Xunit
open FsCheck

[<Fact>]
let ``Every Integer divided by Integer multiplied by same Integer remains itself`` () =
  let intDivIntMulSameIntRemainsItself (a:int) (b':NonZeroInt) =
    let b = b' .Get
    a .div b * (float b) |> should (equalWithin 0.1) (float a)
  Check.QuickThrowOnFailure intDivIntMulSameIntRemainsItself