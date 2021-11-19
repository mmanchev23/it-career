using System;
using System.Collections.Generic;
using System.Text;

namespace Division_without_remainder.Views
{
    class Display
    {
        public int Input { get; set; }

        public (double p1, double p2, double p3) Output { get; set; }

        public Display()
        {
            Input = 0;
            Output = (0.0, 0.0, 0.0);
            GetValues();
        }

        private void GetValues()
        {
            this.Input = int.Parse(Console.ReadLine());
        }

        public void PrintOutput()
        {
            Console.WriteLine(
                "\n" +
                $"{Math.Round(this.Output.p1, 2)}%\n" +
                $"{Math.Round(this.Output.p2, 2)}%\n" +
                $"{Math.Round(this.Output.p3, 2)}%");
        }
    }
}
