module Main

open System
open Funcoes

[<EntryPoint>]
let main argv =
    printfn "Ordena items, em maiúsculas"
    
    let mutable listaNomes : string list = []

    let mutable nome = Console.ReadLine()

    while nome <> "" do
        listaNomes <- List.append listaNomes [nome]
        nome <- Console.ReadLine()

    printfn "Lista simples"
    imprimirNomes listaNomes

    printfn ""
    Console.ReadKey() |> ignore

    printfn "Lista com funcoes encadeadas"
    listaNomes
    |> ordenarDerescente
    |> converterMaiusculas
    |> imprimirNomes

    printfn ""
    Console.ReadKey() |> ignore


    printfn "Lista com funcoes de alta ordem maiusculas"
    imprimirNomesAlteracaoCaixa listaNomes converterMaiusculas imprimirNomes

    printfn ""
    Console.ReadKey() |> ignore

    printfn "Lista com funcoes de alta ordem decrescente"
    imprimirNomesAlteracaoCaixa listaNomes ordenarDerescente imprimirNomes

    printfn ""
    Console.ReadKey() |> ignore

    0 // return an integer exit code