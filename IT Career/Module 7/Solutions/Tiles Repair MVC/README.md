# Tiles repair

Tiles must be placed on the site in front of the apartment building. The site is square in shape with a side of N meters. The tiles are "W" meters wide and "L" meters long. There is a bench on the site with a width of M meters and a length of O meters. There is no need to put tiles under it. Each tile is placed for 0.2 minutes.
Write a program that reads from the console the dimensions of the site, the tiles and the bench and calculates how many tiles are needed to cover the site and calculates the time to place all the tiles.

Example: a site with a size of 20 m. has an area of ​​400 square meters. Bench 1m wide. and 2 m long, occupies an area of ​​2 sq.m. One tile is 5 m wide. and 4m long. has an area = 20sq.m. The area to be covered is 400 - 2 = 398 sq.m. 398/20 = 19.90 tiles are needed. The required time is 19.90 * 0.2 = 3.98 minutes.

# Input

5 numbers are read from the console:
• N - the length of the side of the site in the interval [1 ... 100]
• W - the width of one tile in the interval [0.1 ... 10.00]
• L - the length of one tile in the interval [0.1 ... 10.00]
• M - the width of the bench in the range [0 ... 10]
• O - the length of the bench in the interval [0 ... 10]

# Output

Print two numbers on the console: the number of tiles needed for repair and installation time, each on a new line.

# Sample input and output

| Input | Output | Explanations |
|---|---|---|
| 20 | 19.9 | Total area = 20 * 20 = 400; bench area = 1 * 2 = 2 |
| 5 | 3.98 | Coverage area = 400 - 2 = 398 |
| 4 |   | Tile area = 5 * 4 = 20 |
| 1 |   | Required tiles = 398/20 = 19.9 |
| 2 |   | Time required = 19.9 * 0.2 = 3.98 |
