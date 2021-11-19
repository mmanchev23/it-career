showPlus s x =
    if null s 
    then show x
    else "(" ++ s ++ "+" ++ (show x) ++ ")"

generateMathExpression list = foldl showPlus "" list