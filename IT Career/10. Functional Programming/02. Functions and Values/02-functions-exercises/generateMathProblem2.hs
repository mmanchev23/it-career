showPlus' x s = 
    if null s 
    then show x
    else "(" ++ (show x) ++ "+" ++ s ++ ")"

generateMathExpression' list = foldr showPlus' "" list