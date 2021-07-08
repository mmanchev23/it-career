using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colored_Figures
{
    abstract class ColoredFigure
    {
        private string color;
        private double size;

        public string Color
        {
            get => this.color;
            set => this.color = value;
        }

        public double Size
        {
            get => this.size;
            set => this.size = value;
        }

        public ColoredFigure(string color, double size)
        {
            this.Color = color;
            this.Size = size;
        }

        public ColoredFigure() { }

        public void Show() => Console.WriteLine($"{GetName()}:\nColor: {this.Color}\nSize: {this.Size}\nArea: {this.GetArea():F2}");
        abstract public string GetName();
        abstract public double GetArea();
    }
}
