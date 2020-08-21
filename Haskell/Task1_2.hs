nod a b 
	| b == 0 = a 
	| otherwise = nod b (a `mod` b)