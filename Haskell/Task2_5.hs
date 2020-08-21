firstElem (a,_) = a
secondELem (_,b) = b

bite a b
    |firstElem a == firstElem b = True
    |secondELem a == secondELem b = True
    |secondELem a - secondELem b == firstElem a - firstElem b = True
    |secondELem a - secondELem b == firstElem b - firstElem a = True
    |firstElem b - firstElem a == secondELem a - secondELem b = True
    |otherwise = False

allBites acc a [] = acc
allBites acc a (h:t) = 
    if(bite a h) then allBites (h:acc) a t
    else allBites acc a t

checkPair (h:t) = 
    if t == [] then False
    else True
delUnpair acc [] = acc
delUnpair acc (h:t) =
    if checkPair h then delUnpair (h:acc) t
    else delUnpair acc t

findBites [] = []
findBites (h:t) = 
    let lst = allBites [] h (h:t):findBites t in delUnpair [] lst

{-findBites [(1,1),(2,2),(3,4),(8,3),(7,4),(5,8)]
-}