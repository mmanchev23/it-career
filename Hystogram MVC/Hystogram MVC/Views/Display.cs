using System;
using System.Collections.Generic;
using System.Text;

namespace Hystogram_MVC.Views
{
    class Display
    {
        public int Input { get; set; }

        public (double p1, double p2, double p3, double p4, double p5) Percentages { get; set; }

        public Display()
        {
            this.Input = 0;
            this.Percentages = (0.0, 0.0, 0.0, 0.0, 0.0);
            GetValues();
        }

        private void GetValues()
        {
            this.Input = int.Parse(Console.ReadLine());
        }

        public void PrintOutput()
        {
            Console.WriteLine(
                $"{Math.Round(this.Percentages.p1, 2)}%\n" +
                $"{Math.Round(this.Percentages.p2, 2)}%\n" +
                $"{Math.Round(this.Percentages.p3, 2)}%\n" +
                $"{Math.Round(this.Percentages.p4, 2)}%\n" +
                $"{Math.Round(this.Percentages.p5, 2)}%");
        }
    }
}
