main :: IO ()
main = do
    line <- getLine
    let radius = read line :: Float

    print (radius * radius * pi)
