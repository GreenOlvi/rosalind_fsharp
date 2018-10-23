open System
open System.IO

let transcribe l =
    match l with
    | 'A' -> 'A'
    | 'C' -> 'C'
    | 'G' -> 'G'
    | 'T' -> 'U'
    | _ -> invalidArg "l" "Argument should be one of [ACGT]"

let solve (input:string) =
    let chars = input |> Seq.map transcribe 
    String.Join("", chars)

let readFile input = File.ReadAllText(input).Trim()

let result = solve (readFile "rosalind_rna.txt")

printfn "%s" result