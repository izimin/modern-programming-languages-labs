searchDescendan name lst = findSons name lst lst where
	findSons _ [] _ = []
	findSons name ((f,s):t) lst
		| f == name = s : (findSons s lst lst) ++ (findSons name t lst)
		| otherwise = findSons name t lst

-- searchDescendan [("Vlad", "Igor"), ("Igor", "Den"), ("Den", "Dima"), ("Vlad", "Ilya"), ("Igor", "Andrey"), ("Daniil", "Ignat")]