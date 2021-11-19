main = do
    pointAXLine <- getLine
    pointAYLine <- getLine
    pointBXLine <- getLine
    pointBYLine <- getLine
    pointCXLine <- getLine
    pointCYLine <- getLine
    let pointAX = read pointAXLine :: Integer
    let pointAY = read pointAYLine :: Integer
    let pointBX = read pointBXLine :: Integer
    let pointBY = read pointBYLine :: Integer
    let pointCX = read pointCXLine :: Integer
    let pointCY = read pointCYLine :: Integer
    if(pointCX >= pointAX && pointCX <= pointBX)
    then if (pointCY >= pointAY && pointCY <= pointBY)
        then putStrLn "INSIDE"
        else putStrLn "OUTSIDE"
    else putStrLn "OUTSIDE"