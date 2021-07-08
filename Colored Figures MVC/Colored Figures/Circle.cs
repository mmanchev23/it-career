using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colored_Figures
{
    class Circle : ColoredFigure
    {
        public Circle(string color, double size) : base(color, size) { }

        public Circle() : base() { }

        public override string GetName() => "Circle";

        public override double GetArea() => base.Size * base.Size * Math.PI;
    }
}
