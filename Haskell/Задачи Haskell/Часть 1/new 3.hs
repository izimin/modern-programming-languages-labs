del [h] = [h]
del [] = []
del (h:_:t) = (h:del t)
