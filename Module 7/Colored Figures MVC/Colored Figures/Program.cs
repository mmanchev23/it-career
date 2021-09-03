using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colored_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Triangle triangle = new Triangle();
            Circle circle = new Circle();
            Square square = new Square();
            ColoredFigure coloredFigure;

            string figure, color;
            double size;

            for (int i = 0; i < n; i++)
            {
                figure = Console.ReadLine();
                color = Console.ReadLine();
                size = double.Parse(Console.ReadLine());

                if (figure == "Circle")
                {
                    coloredFigure = new Circle(color, size);
                    coloredFigure.Show();
                }
                else if (figure == "Square")
                {
                    coloredFigure = new Square(color, size);
                    coloredFigure.Show();
                }
                else if (figure == "Triangle")
                {
                    coloredFigure = new Triangle(color, size);
                    coloredFigure.Show();
                }
            }
        }
    }
}
