dropEvery :: [a] -> Int -> [a]
dropEvery [] _ = []
dropEvery list count = (take (count-1) list) ++ dropEvery (drop count list) count