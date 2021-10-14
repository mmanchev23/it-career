# Transport-MVC

A student has to travel n kilometers. He has a choice between three modes of transport:

• Taxi. Starting fee: BGN 0.70. Daily tariff: BGN 0.79 / km. Night tariff: BGN 0.90 / km.
• Bus. Day / night tariff: BGN 0.09 / km. Can be used for distances of at least 20 km.
• Train. Day / night tariff: BGN 0.06 / km. Can be used for distances of at least 100 km.

Write a program that enters the number of kilometers n and the period of the day (day or night)
and calculates the price of the cheapest transport.

# Input

Two lines are read from the console:

• The first line contains the number n - number of kilometers - integer in the interval [1… 5000].
• The second line contains the word "day" or "night" - travel during the day or at night.

# Output

To print on the console the lowest price for the specified number of kilometers.

# Sample input and output

| Input   | Output | Explanations                                                                                               |
|---------|--------|------------------------------------------------------------------------------------------------------------|
| 5       | 4.65   | The distance is less than 20 km само only taxis can be used. The starting fee is BGN 0.70.                 |
| day     |        | As it is during the day, the tariff is 0.79 BGN / km. With taxis the price is: 0.70 + 5 * 0.79 = BGN 4.65. |
