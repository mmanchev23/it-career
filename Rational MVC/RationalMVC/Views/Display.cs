using System;

namespace RationalMVC.Views
{
    class Display
    {
        public int R1a { get; set; }
        public int R1b { get; set; }
        public int R2a { get; set; }
        public int R2b { get; set; }
        public string Rational1 { get; set; }
        public string Rational2 { get; set; }
        public string OutputPlus { get; set; }
        public string OutputMinus { get; set; }
        public string OutputMultiply { get; set; }
        public string OutputDevide { get; set; }
        public string OutputCompare { get; set; }

        public Display()
        {
            R1a = 0;
            R1b = 0;
            R2a = 0;
            R2b = 0;
            Rational1 = "";
            Rational2 = "";
            OutputPlus = "";
            OutputMinus = "";
            OutputMultiply = "";
            OutputDevide = "";
            OutputCompare = "";
            GetValues();
        }

        private void GetValues()
        {
            Console.Write("What's the value of a? ");
            R1a = int.Parse(Console.ReadLine());

            Console.Write("What's the value of b? ");
            R1b = int.Parse(Console.ReadLine());

            Console.Write("What's the value of c? ");
            R2a = int.Parse(Console.ReadLine());

            Console.Write("What's the value of d? ");
            R2b = int.Parse(Console.ReadLine());
        }

        public void PrintResult()
        {
            Console.WriteLine($"r1 = {Rational1}");

            Console.WriteLine($"r2 = {Rational2}");

            Console.WriteLine($"r1 + r2 = {OutputPlus}");

            Console.WriteLine($"r1 - r2 = {OutputMinus}");

            Console.WriteLine($"r1 * r2 = {OutputMultiply}");

            Console.WriteLine($"r1 / r2 = {OutputDevide}");

            Console.WriteLine($"The biggest from the both rationals is {OutputCompare}");
        }
    }
}
