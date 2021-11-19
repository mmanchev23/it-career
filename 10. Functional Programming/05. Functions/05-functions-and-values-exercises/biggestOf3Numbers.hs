biggestOf3 a b c = 
                if a > b
                then if a > c
                    then a
                    else c
                else if b > c
                    then b
                    else c