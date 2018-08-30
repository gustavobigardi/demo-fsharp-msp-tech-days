module Funcoes

open System

let ordenarCrescente listaNomes=
    List.sort listaNomes

let ordenarDerescente listaNomes =
    List.sortDescending listaNomes

let converterMaiusculas listaNomes =
    listaNomes 
    |> List.map (fun nome -> nome.ToString().ToUpper())

let converterMinusculas listaNomes =
    listaNomes 
    |> List.map (fun nome -> nome.ToString().ToLower())

let imprimirNomes listaNomes =
    listaNomes
    |> List.iter (fun nome -> printfn "%s" nome)

let imprimirNomesAlteracaoCaixa listaNomes funcaoCaixa funcaoImprimir =
    listaNomes
    |> funcaoCaixa
    |> funcaoImprimir