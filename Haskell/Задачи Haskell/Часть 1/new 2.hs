nod m n 
    | m > n = nod (m-n) n
    | n > m = nod m (n-m)
    |otherwise = m