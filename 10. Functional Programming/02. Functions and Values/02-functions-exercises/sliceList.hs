sliceList list start end = map snd
                            $ filter (\ (x,_) -> x >= start && x <= end)
                            $ zip [0..] list
                            
sliceList' list start end = drop (start-1) 
                            $ take end list