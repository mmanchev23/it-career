# Hystogram MVC

N integers are given in the interval [1… 1000]. Of these, some percentage of p1 is below 200, another percentage of p2 is from 200 to 399, another percentage of p3 is from 400 to 599, another percentage of p4 is from 600 to 799 and the remaining p5 percent is from 800 up. Write a program that calculates and prints the percentages p1, p2, p3, p4 and p5.
Example: we have n = 20 numbers: 53, 7, 56, 180, 450, 920, 12, 7, 150, 250, 680, 2, 600, 200, 800, 799, 199, 46, 128, 65. We get the following distribution and visualization:

| Range | Numbers in range | Quantity of numbers| Percentage |
| --- | --- | --- | --- |
| < 200 | 53, 7, 56, 180, 12, 7, 150, 2, 199, 46, 128, 65 | 12 | p1 = 12 / 20 * 100 = 60.00% |
| 200 … 399 | 250, 200 | 2 | p2 = 2 / 20 * 100 = 10.00% |
| 400 … 599 | 450 | 1 | p3 = 1 / 20 * 100 = 5.00% |
| 600 … 799 | 680, 600, 799 | 3 | p4 = 3 / 20 * 100 = 15.00% |
| ≥ 800 | 920, 800 | 2 | p5 = 2 / 20 * 100 = 10.00% |

# Input

On the first line of the input is the integer n (1 ≤ n ≤ 1000) - number of numbers. The next n lines contain an integer in the interval [1… 1000] - the numbers on which to calculate the histogram.

# Output

Print the histogram on the console - 5 lines, each of which contains a number between 0% and 100%, with an accuracy of two digits after the decimal point, for example 25.00%, 66.67%, 57.14%.

# Sample Input and Output

| Input | Output |
| --- | --- |
| 3 | 66.67% |
| 1 | 0.00% |
| 2 | 0.00% |
| 999 | 0.00% |
|   | 33.33% |
