minDistCity list = f list (minDist list) where 
	f [] _ = []
	f ((a,b,c):tail) min 
	   	|min == c = (a,b):(f tail min)
	   	|otherwise = f tail min
	minDist [] = 0
	minDist [(_,_,c)] = c
	minDist ((_,_,c):xs) = min c (minDist xs)

-- minDistCity [("A", "B", 5),("D", "C", 7),("E", "A", 3),("B", "C", 3),("D", "C", 7)]