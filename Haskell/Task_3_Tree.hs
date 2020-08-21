-- Сттруктура дерева 
data Tree a =
	  None 
	| Node a (Tree a) (Tree a) deriving (Show)

-- обобщающая функция - считает значение выражения
calc str = calcOPZ (opz (createTree str))

-- Задание №1 (построение бинарного дерева, соответствующего выражению)
newTree str = printTree (createTree str) 

-- Задание №2 (концевой обход для получения ОПЗ)
makeOPZ str = opz (createTree str)

-- Задание №3 (вычисление выражения по ОПЗ)		foldl - левосторонняя свертка, head возвращает вершину стека
calcOPZ str = head (foldl foldingFunction [] (words str))
  where
    foldingFunction (x:y:ys) "*" = (x * y):ys			
    foldingFunction (x:y:ys) "/" = (y `div` x):ys
    foldingFunction (x:y:ys) "+" = (x + y):ys
    foldingFunction (x:y:ys) "-" = (y - x):ys
    foldingFunction xs numberString = read numberString:xs    

-- Печать дерева на экран в скобочной форме
printTree None = ""																						
printTree (Node x None None) = x																		
printTree (Node x left right) = "(" ++ printTree left ++ ")" ++ x ++ "(" ++ printTree right ++ ")"		

makeNode tree [] = (tree, [])
makeNode tree (op:x:t) =  if op == "-" || op == "+"  then (tree, (op:(x:t))) 
						  else makeNode (Node op tree (Node x None None)) t

createNode tree [] = tree 
createNode tree (op:x:t) = createNode (Node op tree subTree) lst where
						   (subTree, lst) = makeNode (Node x None None) t 

-- Создание дерева по выражению 
createTree str = firstLeftTree (words str) where
	firstLeftTree [] = None												-- на вход подана пустая строка
	firstLeftTree (h:t) = createNode firstNode remLst where				-- создали самый нижний левый узел 
						  (firstNode, remLst) = makeNode (Node h None None) t 

-- Концевой обход, получение ОПЗ (левое - правое - корень, то есть обратный обход)
opz None = ""
opz (Node x None None) = x ++ " " 
opz (Node x left right) = opz left ++ " "  ++ opz right ++ " "  ++ x ++ " " 