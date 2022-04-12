namespace Streaks.FSharp

module FsSolution =
    let ComputeLength (s : string) =
        let rec f (i: int) (c: int) (g: int) =
            match i with
            | 0 -> max c g
            | _ when s.[i] = s.[i-1] -> f (i-1) (c+1) g
            | _ -> f (i-1) 1 (max c g)
        f (s.Length - 1) 1 1