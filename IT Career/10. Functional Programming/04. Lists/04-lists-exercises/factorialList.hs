factorial n = findFactorial n 1 1 []
findFactorial n initialValue index resultList =
    if index > n
    then resultList
    else findFactorial n (initialValue * index) (index + 1) (resultList ++ [initialValue])