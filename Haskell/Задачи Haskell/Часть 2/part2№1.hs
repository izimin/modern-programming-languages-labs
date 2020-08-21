thirdElem :: Ord a => (b,c,a) -> a
thirdElem (_,_,c) = c

qsort :: Ord a => [(b,c,a)] -> [(b,c,a)]
qsort [] = []
qsort (h:t) = 
    let third = thirdElem h in
    qsort[x|x<-t, thirdElem x <= third]++[h]++qsort[x|x<-t, thirdElem x > third]

equalDistances (a:b) [] = (a:b)
equalDistances (a:b) (h:t) = 
    if thirdElem a == thirdElem h then equalDistances (h:a:b) t
    else (a:b)

minDist lst = 
    let (h:t) = qsort lst in equalDistances [h] t