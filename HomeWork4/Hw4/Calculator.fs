﻿module Hw4.Calculator

open System

let calculate (value1 : double) (operation : CalculatorOperation) (value2 : double) =
    match operation with
    | CalculatorOperation.Plus -> value1 + value2
    | CalculatorOperation.Minus -> value1 - value2
    | CalculatorOperation.Multiply -> value1  * value2
    | CalculatorOperation.Divide -> value1 / value2
    | _ -> ArgumentOutOfRangeException() |> raise
    