fibonacci n = findFibonacci n 1 0 1
findFibonacci n initialValue prevValue index =
    if index >= n 
    then initialValue
    else findFibonacci n (initialValue + prevValue) initialValue (index + 1)