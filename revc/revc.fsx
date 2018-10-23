open System
open System.IO

type DNA = A | C | G | T

let complement l =
    match l with
    | A -> T
    | C -> G
    | G -> C
    | T -> A

let parseDNA l =
    match l with
    | 'A' -> A
    | 'C' -> C
    | 'G' -> G
    | 'T' -> T
    | _ -> invalidArg "l" "Argument should be one of [ACGT]"

let dnaToChar d =
    match d with
    | A -> 'A'
    | C -> 'C'
    | G -> 'G'
    | T -> 'T'

let solve (input:string) =
    let chars =
        input
        |> Seq.rev
        |> Seq.map (parseDNA >> complement >> dnaToChar)
    String.Join("", chars)

let readFile input = File.ReadAllText(input).Trim()

let result = solve (readFile "rosalind_revc.txt")

printfn "%s" result