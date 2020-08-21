findLast [] = 0
findLast lst = last 1 lst where
	last _ [h] = h
	last i (h:t)= if i == 5 then last 1 t
				else last (i+1) (t++[h])

-- findLast ["David", "Dianus", "Ilya", "Ignat", "Sveta", "Romandron"]