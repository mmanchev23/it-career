printTriangle 0 = return ()
printTriangle n = 
    do
        putStrLn (asterixStringRow n)
        printTriangle (n - 1)

asterixStringRow n = replicate n '*'