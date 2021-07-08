using RationalMVC.Models;
using RationalMVC.Views;

namespace RationalMVC.Controllers
{
    class RationalController
    {
        private Rational rational1;
        private Rational rational2;
        private Display display;

        public RationalController()
        {
            display = new Display();
            rational1 = new Rational(display.R1a, display.R1b);
            rational2 = new Rational(display.R2a, display.R2b);

            display.Rational1 = rational1.ToString();
            display.Rational2 = rational2.ToString();
            display.OutputPlus = rational1.Plus(rational2).ToString();
            display.OutputMinus = rational1.Minus(rational2).ToString();
            display.OutputMultiply = rational1.Multiply(rational2).ToString();
            display.OutputDevide = rational1.Devide(rational2).ToString();
            display.OutputCompare = Rational.Compare(rational1, rational2).ToString();

            display.PrintResult();
        }
    }
}
