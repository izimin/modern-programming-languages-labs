namespace KnapsackLibrary
open Knapsack

type KnapsackSolve() =
    member this.GetName() = (this :> Knapsack.ISolver).GetName()
    member this.Solve = (this :> Knapsack.ISolver).Solve

    interface Knapsack.ISolver with
        member this.GetName() = "Greedy Algorithm"
        member this.Solve(W, w, c) = 
            let list = this.UnionList (w |> Array.toList) (c |> Array.toList)
            let sortList = List.sortByDescending (fun (w, c,_) -> double c / double w) list
            this.MySolve (List.length sortList) sortList W |> List.toArray 

    member this.UnionList = this.GetUnionList [] 1
    member this.GetUnionList result i (w : int list) (c : int list) =
        match w, c with
        |h1::t1, h2::t2 -> this.GetUnionList ((h1, h2, i)::result) (i + 1) t1 t2
        |_, _ -> result
    
    member this.MySolve count = this.GetResultList 0 (List.map(fun x -> false) [1..count])  // [for i in 1..count -> false]
    member this.GetResultList curWeith result list W  =
        match list with
        |[] -> result
        |(w, _, i)::t -> if (curWeith + w <= W) then 
                                this.GetResultList (curWeith + w) (this.ChangeResultList result i) t W 
                                else this.GetResultList curWeith result t W
    
    member this.ChangeResultList = this.GetChangeList 1
    member this.GetChangeList i ref num =
        match ref with
        |[] -> []
        |h::t -> if (i = num) then true::t else h::this.GetChangeList (i + 1) t num