import Data.List

data BinTree = 
      None
      | Node ([Char], BinTree, BinTree) 
      deriving (Show)

printTree :: BinTree -> [Char]
printTree None = []
printTree Node (x, None, None) = show x
printTree Node (x, left, right) = "(" ++ printTree left ++ ")" ++ show x ++ "(" ++ printTree right ")"

--printHead lst = head (lst)     

--1 - +
--2 * /
--countFirstOp x lst 
--    |[] = x
--    |(h:t) = if (h == '+' || h == '-') then countFirstOp (x+1) t else countFirstOp x t
    
--countSecondOp x lst 
--    |[] = x
 --   |(h:t) = if (h == '*' || h == '/') then countSecondOp (x+1) t else countSecondOp x t
 
--создаем дерево из слагаемого(где * и /) 
parseTerm lst = createTerm None lst where
  createTerm tree [] = (tree, [])
  createTerm tree (op:num:t) = if (op <> "-" && op <> "+") then createTerm (Node (op, tree, num)) t else (tree, ([op]++[num]++t))

--создает дерево там где + и - 
createItem tree [] = tree 
createItem  tree (op:r) = 
        let (add2, r2) = parseTerm r 
        in createItem Node(op, t, add2) r2

--делаем дерево из строки
makeNewExpr str =
      let (add1, rest) = parseTerm str
      in createItem add1 rest
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
createReverse lst = reverse (words lst)

createBinaryTree lst
    |tree [] = tree
    
createWithSecondOp (h:[]) [] = h 
createWithSecondOp right (h:left) = if (h == "*" || h == "/") then Node (h, createWithFirstOp [] right, createWithFirstOp [] left) 
                                                             else createWithFirstOp (right ++ [h]) left    
    
createWithFirstOp (h:[]) [] = h   
createWithFirstOp right [] = createWithSecondOp [] right 
createWithFirstOp right (h:left) = if (h == "-" || h == "+") then Node (h, createWithFirstOp [] right, createWithFirstOp [] left) 
                                                             else createWithFirstOp (right ++ [h]) left