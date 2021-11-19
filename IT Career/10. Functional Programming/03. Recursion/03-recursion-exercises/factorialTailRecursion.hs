factorial n = findFactorial n 1 1
findFactorial n initialValue index =
    if index > n
    then initialValue
    else findFactorial n (initialValue * index) (index + 1)