let Fst (c,_,_) = c
let Snd (_,c,_) = c
let thd (_,_,c) = 

let rec main tree graph visited (unvisited : int list) =
    if (unvisited = []) then tree else
    let list = List.filter (fun (f, t, w) -> List.contains f visited && List.contains t unvisited || List.contains t visited && List.contains f unvisited) graph
    let min = List.minBy (fun (f, t, w) -> w) list
    main (min::tree) graph ((Fst min)::(Snd min)::visited) (List.filter (fun x -> x <> (Fst min) && x <> (Snd min) ) unvisited)

let Prime graph = 
    let min = List.min (List.map (fun (f, t, w) -> min f t) graph)
    let max = List.max (List.map (fun (f, t, w) -> max f t) graph)
    main [] graph [min] [for i in (min + 1)..max -> i]

let graph = [(1,2,3.0); (2,4,5.0); (1,4,2.0); (1,3,1.0); (3,4,0.5)]

let res = Prime graph

let graph2 = [(0, 1, 1.5); (1, 5, 2.5); (1, 2, 5.7); (3, 2, 3.9); (4, 3, 4.7); (4, 5, 11.8)]
let graph3 = [(0, 1, 6);(0, 2, 8);(0, 3, 5);(0, 4, 5); (0, 5, 4); (1, 2, 7);(1, 3, 7);(1, 4, 6);(1, 5, 2);(2, 3, 5);(2, 4, 10);(2, 5, 10);(3, 4, 7);(3, 5, 10);(4, 5, 3)]
let res2 = Prime graph2
printfn "%A" res