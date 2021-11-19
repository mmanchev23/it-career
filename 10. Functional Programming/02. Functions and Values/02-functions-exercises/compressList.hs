compress [] = []
compress x = foldr (\a b -> if a == (head b) then b else a:b) [last x] x