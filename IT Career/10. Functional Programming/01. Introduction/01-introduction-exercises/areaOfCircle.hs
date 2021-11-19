main = do
    line <- getLine
    let radius = read line :: Float
    putStrLn (show (radius * radius * pi))