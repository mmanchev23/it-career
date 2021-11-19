main = do
    firstName <- getLine
    lastName <- getLine
    putStrLn (firstName ++ " " ++ lastName)