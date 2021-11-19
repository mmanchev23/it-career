using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colored_Figures
{
    class Square : ColoredFigure
    {
        public Square(string color, double size) : base(color, size) { }

        public Square() : base() { }

        public override string GetName() => "Square";

        public override double GetArea() => base.Size * base.Size;
    }
}
