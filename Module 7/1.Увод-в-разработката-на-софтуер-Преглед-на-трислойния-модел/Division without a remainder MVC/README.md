# Division-without-remainder

N integers are given in the interval [1… 1000]. Of these, some percentage p1 is divisible by 2, another percentage is divided by 3, another percentage p3 is divisible by 4. Write a program that calculates and prints the percentages p1, p2 and p3.

Example: we have n = 10 numbers: 680, 2, 600, 200, 800, 799, 199, 46, 128, 65. We get the following distribution and visualization:

| Division without remainder | Numbers in the range | Number of numbers | Percentage |
| --- | --- | --- | --- |
| 2 | 680, 2, 600, 200, 800, 46, 128 | 7 | p1 = 7.0 / 10 * 100 = 70.00% |
| 3 | 600 | 1 | p2 = 1 / 10 * 100 = 10.00% |
| 4 | 680, 600, 200, 800, 128 | 5 | p3 = 5 / 10 * 100 = 50.00% |

# Input

On the first line of the input is the integer n (1 ≤ n ≤ 1000) - number of numbers. The next n lines contain an integer in the interval [1… 1000] - the numbers to be checked by how much they are divisible.

# Output

Print 3 lines on the console, each containing a percentage between 0% and 100%, to two decimal places, for example 25.00%, 66.67%, 57.14%.

• On the first line - the percentage of numbers that are divisible by 2
• On the second line - the percentage of numbers that are divisible by 3
• On the third line - the percentage of numbers that are divisible by 4

# Sample input and output

| Input | Output |
| --- | --- |
| 10 | 70.00% |
| 680 | 10.00% |
| 2 | 50.00% |
| 600 |   |
| 200 |   |
| 800 |   |
| 799 |   |
| 199 |   |
| 46 |   |
| 128 |   |
| 65 |   |
