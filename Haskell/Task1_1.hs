c n m = if  m == 0   then  1
		else (n * c (n-1) (m-1)) `div` m