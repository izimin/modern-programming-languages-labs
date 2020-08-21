secondElem (_,b) = b

qsort :: Ord a => [(b,a)] -> [(b,a)]
qsort [] = []
qsort (h:t) = 
    let second = secondElem h in
    qsort[x|x<-t, secondElem x >= second]++[h]++qsort[x|x<-t, secondElem x < second]

equalDays (a:b) [] = (a:b)
equalDays (a:b) (h:t) = 
    if secondElem a == secondElem h then equalDays (h:a:b) t
    else (a:b)

minDist lst = 
    let (h:t) = qsort lst in equalDays [h] t