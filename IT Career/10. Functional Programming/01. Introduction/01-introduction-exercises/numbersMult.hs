main = do
    firstLine <- getLine
    secondLine <- getLine
    let firstNum = read firstLine :: Integer
    let secondNum = read secondLine :: Integer
    putStrLn (show (firstNum * secondNum))