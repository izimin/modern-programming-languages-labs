thd (_,_,c) = c
minim (h:[]) = h
--minim (h:t) = if thd h < thd (minim t) then minim t else minim t 
minim (h:t) = if thd h < thd (minim t) then h else minim t 
maxim acc [] = acc
maxim acc ((u,v,w):t) = if u > v && u > acc then maxim u t else if v > acc then maxim v t else maxim acc t

prima2 mst _ _ [] = mst
prima2 mst graph usedV notUsedV = 
    prima2 ((f,s,t):mst) graph (f:s:usedV) (filter (\x -> x /= f && x /= s) notUsedV) where 
    (f,s,t) = minim (filter (\(u, v, w) -> (elem u usedV) && (elem v notUsedV) || (elem v usedV) && (elem u notUsedV)) graph)
prima lst = prima2 [] lst [0] [0..(maxim 0 lst)]


--prima [(0, 1, 5),(0, 2, 3),(1, 2, 1)]
--[(0, 1, 5),(0, 2, 1),(0, 4, 2),(1, 2, 3),(2, 3, 4),(3, 4 , 11)]
--[(0, 1, 6),(0, 2, 8),(0, 3, 5),(0, 4, 5),(0, 5, 4),(1, 2, 7),(1, 3, 7),(1, 4, 6),(1, 6, 2),(2, 3, 5),(2, 4, 10),(2, 5, 10),(3, 4, 7),(3, 5, 10), (4, 5, 3)]
--prima [(0,1,5),(0,6,3),(0,5,9),(1,6,4),(1,7,2),(1,2,9),(2,7,9),(2,8,7),(2,9,5),(2,3,4),(3,9,1),(3,4,4),(4,9,3),(4,8,10),(4,5,18),(5,8,8),(5,6,9),(6,7,2),(6,8,9),(7,8,8),(8,9,9)]
--prima [(0,1,3),(1,2,4),(1,19,12),(19,20,13),(1,18,7),(15,18,1),(2,3,5),(3,17,8),(17,16,7),(3,4,3),(4,5,4),(5,6,1),(6,7,8),(7,8,7),(8,9,6),(9,10,5),(8,11,4),(11,12,1),(12,13,8),(13,14,9)]