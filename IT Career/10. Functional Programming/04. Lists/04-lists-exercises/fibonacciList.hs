fibonacci n = findFibonacci n 1 0 1 []
findFibonacci n initialValue prevValue index resultList =
    if index > n 
    then resultList
    else findFibonacci n (initialValue + prevValue) initialValue (index + 1) (resultList ++ [initialValue])