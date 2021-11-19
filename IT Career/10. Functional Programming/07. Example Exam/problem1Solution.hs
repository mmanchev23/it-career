import System.Exit ( exitSuccess )

main :: IO b
main = do
    numberToWord

numberToWord :: IO b
numberToWord = do
    line <- getLine
    if line == "End"
    then exitSuccess
    else do
        let number = read line :: Integer
        printNumber number
        numberToWord

printNumber :: (Eq a, Num a) => a -> IO ()
printNumber number
        | number == 0 = do
            putStrLn "Zero"
        | number == 1 = do
            putStrLn "One"
        | number == 2 = do
            putStrLn "Two"
        | number == 3 = do
            putStrLn "Three"
        | number == 4 = do
            putStrLn "Four"
        | number == 5 = do
            putStrLn "Five"
        | number == 6 = do
            putStrLn "Six"
        | number == 7 = do
            putStrLn "Seven"
        | number == 8 = do
            putStrLn "Eight"
        | number == 9 = do
            putStrLn "Nine"
        | otherwise = do
            putStrLn "Please only enter single digit positive numbers"
