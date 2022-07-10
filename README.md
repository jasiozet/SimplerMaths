# Simpler Maths

F# library to help you solve exercises/katas/koans etc.

## Reasoning

In F# division operator / for ints is very strict. It won't let you divide float by int and it is an integer division operator for ints and longs.
Inspired by this [discussion](https://github.com/fsharp/fslang-suggestions/issues/1161). I decided to try making a simple, small library to help with the usecases

## Features

### "True" division

Simpler maths exposes:

* ```div``` - normal function (prefix operator)
* ```.div``` - infix operator

For ```int```, ```long``` and ```float```

Examples:

```
1 .div 2 // 0.5
1L .div 4 // 0.25
2.0 .div 4 // 0.5
```

## Todo:

* Prepare a nuget package
* Publish a nuget package
* ```mod``` / ```.mod``` - modulo operator
* ```.pown``` - infix for ```pown``` function
* Github actions for CI pipeline

## Stuff used:

* [xUnit](https://xunit.net/)
* [FsUnit](https://fsprojects.github.io/FsUnit/)
* [FsCheck](https://fscheck.github.io/FsCheck/)