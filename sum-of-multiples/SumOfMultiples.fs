﻿module SumOfMultiples

    let change (value: int) (numbers: int list) : int list  = 
             List.filter(fun f -> value % f = 0) numbers
         

    let sum (numbers: int list) (upperBound: int): int = 
        [1..upperBound-1]
        |> List.filter(fun e ->
                    numbers 
                    |> List.exists(fun f -> e % f = 0))
        |> List.sum

    // |> list.filter (fun f -> upperBound % f = 0 && f = upperBound)

// let divides (input: int) (modulus: int): bool = input % modulus = 0

// let isDivisibleByAny (numbers: int list) (input: int): bool = List.exists (divides input) numbers
// let sum (numbers: int list) (upperBound: int): int = 
//     [0..upperBound]
//     |> List.filter (isDivisibleByAny numbers) 
//     |> List.sum 