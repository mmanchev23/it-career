duplicate [] = []
duplicate (x:xs) = x:x:duplicate xs