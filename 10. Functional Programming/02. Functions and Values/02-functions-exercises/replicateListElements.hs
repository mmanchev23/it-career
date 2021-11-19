replicateList list n = foldl (\ a b -> a ++ replicate b n) [] list
        where 
            replicate _ 0 = []
            replicate x n = x : replicate x (n - 1)