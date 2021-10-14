# Colored-Figures

Create an abstract ColoredFigure class that has:
• Color field to indicate the color (as a string)
• Size field to indicate the size of the figure
• A constructor that takes color and size as parameters
• Show () method, which prints the color and size of the object.
• Abstract method GetName (), which returns the name of the figure
• Abstract GetArea () method, which returns the face of the figure

Create a Triangle class that inherits ColoredFigure, and this class has:
• A constructor that calls the superclass constructor
• Definition for the abstract method GetName (), this method returns the string "Triangle".
• Definition of the abstract method GetArea (), as this method returns the face of the triangle, the triangle is considered equilateral, with side size. Use the formula:
S = (size^2 * √3) /4

Create a Square class that inherits ColoredFigure, and this class has:
• A constructor that calls the superclass constructor
• Definition for the abstract method GetName (), this method returns the string "Square".
• Definition of the abstract method GetArea (), which returns the face of the square with side size.

Create a Circle class that inherits ColoredFigure, and this class has:
• A constructor that calls the superclass constructor
• Definition of the abstract method GetName (), this method returns the string "Circle".
• Definition of the abstract GetArea () method, which returns the face of the circle with a radius size.

# Input

On the first line of the input there is only an integer N - number of requests. From the following 3 * N lines, an application is submitted in one of the following formats:
• Triangle
• <color>
• <size>

• Circle 
• <color> 
• <size>

• Square
• <color>
• <size>

# Output

For each query you must create an object of the corresponding class, after which you must print 4 lines:
<figure name>:
Color: <color>
Size: <size>
Area: <person>

Print the face exactly two decimal places.

# Examples

| Input | Output |
| --- | --- |
| 3 | Circle: |
| Circle | Color: blue |
| blue | Size: 1 |
| 1 | Area: 3.14 |
| Square | Square: |
| red | Color: red |
| 2 | Size: 2 |
| Triangle | Area: 4.00 |
| green | Triangle: |
| 3 | Color: green |
|   | Size: 3 |
|   | Area: 3.90 |
