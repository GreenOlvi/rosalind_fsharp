open System.IO

type State = { A:int; C:int; G:int; T:int }

let initialState = {A = 0; C = 0; G = 0; T = 0}

let parseLetter (state:State) l =
    match l with
    | 'A' -> {state with A = state.A + 1}
    | 'C' -> {state with C = state.C + 1}
    | 'G' -> {state with G = state.G + 1}
    | 'T' -> {state with T = state.T + 1}
    | _ -> invalidArg "l" "Argument should be one of [ACGT]"

let solve (input:string) = input |> Seq.fold parseLetter initialState

let readFile input = File.ReadAllText(input).Trim()

let result = solve (readFile "rosalind_dna.txt")

printfn "%i %i %i %i" result.A result.C result.G result.T