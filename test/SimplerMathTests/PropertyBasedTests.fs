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

[<Fact>]
let ``Every Float divided by Integer multiplied by same Integer remains itself`` () =
  let intDivIntMulSameIntRemainsItself (a:System.Int64) (b':NonZeroInt) =
    let b = b' .Get
    a .div b * (float b) |> should (equalWithin 0.1) (float a)
  Check.QuickThrowOnFailure intDivIntMulSameIntRemainsItself

[<Fact>]
let ``Every Long divided by Integer multiplied by same Integer remains itself`` () =
  let intDivIntMulSameIntRemainsItself (a':NormalFloat) (b':NonZeroInt) =
    let a = b' .Get
    let b = b' .Get
    a .div b * (float b) |> should (equalWithin 0.1) a
  Check.QuickThrowOnFailure intDivIntMulSameIntRemainsItself
