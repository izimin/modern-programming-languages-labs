import Data.List(minimumBy)
import Data.Function(on)
 
inf = 100000

time :: Int -> Int -> [(Int,Int,Int)] -> IO ()
time s d adjList= do{
    start <- getCurrentTime;
    print $ show (mainDijkstra s d adjList);
    stop <- getCurrentTime;
    print $ diffUTCTime stop start
}

finalAnswer ::Int->[(Int,Int)]->Int
finalAnswer d [] = -1
finalAnswer d (h:t)
    |fst h == d = snd h
    |otherwise  = finalAnswer d t

mainDijkstra s d adjList= 
    finalAnswer d (findMinPath s d adjList)
    

findMinPath s d adjList = dijkstra s d adjList [(s,0)]
 
dijkstra  ::Int->Int->[(Int,Int,Int)]->[(Int,Int)]->[(Int,Int)]
dijkstra  s d adjList visited
    | (p,q) == (inf, inf) = visited  --возвращаем вершины
    | otherwise  = dijkstra p d adjList ((p,q):visited) --добавляем кортеж вида (вершина, минимальное расстояние до неё) в посещённые
    where (p,q) = exploreNeighbours s visited adjList --просмотр соседей

-- доллар - оператор применения, всё, что справа, "заезжает" в то, что слева
exploreNeighbours ::Int->[(Int,Int)]->[(Int,Int,Int)]->(Int,Int)
exploreNeighbours source visited adjList =
  if source `belongsTo` visited --если вершина ведёт в посещённые
    then retMinNode $ --то 
      relax (filter (\(x,y,z) -> not (belongsTo y visited)) adjList) visited --передаём в функцию релакс ещё не посещённые вершины, фильтр здесь нужен для того, 
      --чтобы определить, что вершина ещё не посещена, просматриваем, есть ли она в списке visited. Грубо говоря, накапливаем все пути от одной вершины, до 
      --до другой. И выбираем среди полученного кортежа менимальный (2 элемент которого наименьший) с помощью ретминноде.
    else --если вершина не ведёт ни в одну, то она недостижима
      (inf,inf)
 
belongsTo::Int->[(Int,Int)]->Bool
belongsTo x pairs = elem x (map fst pairs) --проверяет, есть ли х в кортеже
 
-- почленно заменяет в первом списке (x,y,z) на (y, currDist x visited + z)
relax :: [(Int,Int,Int)]->[(Int,Int)]->[(Int,Int)]
relax points visited = map (\(x,y,z) -> (y, currDist x visited + z)) points --для каждого кортежа из списка points применяем функцию (обновляем метки)
           --при этом вернём список кортежей вида (вершина, расстояние до неё)
 
-- currDist n visited ищет в visited последнюю пару вида (n,u) и возвращает u.
currDist :: Int -> [(Int,Int)] -> Int
currDist n visited =  --функция проверяет, оставить метку преженей, или уменьшить её
  foldl (\acc t -> if (fst t == n) then (snd t) else acc) inf visited 
 
-- возвращает пару-элемент с минимальным вторым членом
retMinNode ::[(Int,Int)]->(Int,Int)
retMinNode arr = minimumBy (compare `on` snd) ((inf,inf):arr)

--time = do{
    --start <- getCurrentTime;
    --mainDijkstra 1 6 [(1,2,6),(1,3,1),(1,4,5),(2,1,6),(2,3,5),(2,5,3),(3,1,1),(3,2,5),(3,4,5),(3,5,6),(3,6,4),(4,1,5),(4,3,5),(4,6,2),(5,2,3),(5,3,6),(5,6,6),(6,3,4),(6,4,2),(6,5,6)];
    --stop <- getCurrentTime;
  --  print $ diffUTCTime stop start
--}
--mainDijkstra 1 8 [(7,1,10000000),(7,2,10000000000),(7,3,10000000000),(7,4,10000000000),(7,5,10000000000),(7,6,10000000),(1,2,6),(1,3,1),(1,4,5),(2,1,6),(2,3,5),(2,5,3),(3,1,1),(3,2,5),(3,4,5),(3,5,6),(3,6,4),(4,1,5),(4,3,5),(4,6,2),(5,2,3),(5,3,6),(5,6,6),(6,3,4),(6,4,2),(6,5,6), (7,8,1),(8,1,10000000),(8,2,10000000000),(8,3,10000000000),(8,4,10000000000),(8,5,10000000000),(8,6,10000000)]
--mainDijkstra 1 6 [(1,2,6),(1,3,1),(1,4,5),(2,1,6),(2,3,5),(2,5,3),(3,1,1),(3,2,5),(3,4,5),(3,5,6),(3,6,4),(4,1,5),(4,3,5),(4,6,2),(5,2,3),(5,3,6),(5,6,6),(6,3,4),(6,4,2),(6,5,6)]