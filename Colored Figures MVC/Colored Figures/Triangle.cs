using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colored_Figures
{
    class Triangle : ColoredFigure
    {
        public Triangle(string color, double size) : base(color, size) { }

        public Triangle() : base() { }

        public override string GetName() => "Triangle";

        public override double GetArea() => (base.Size * base.Size * Math.Sqrt(3)) / 4;
    }
}
