sochetanie::Integer->Integer->Integer
f 0 = 1
f n = n * f (n-1)
sochetanie n m = if n >= n then (f n)`div`((f m) * f (n-m)) else -1
