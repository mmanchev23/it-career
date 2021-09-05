using System;
using System.Collections.Generic;
using System.Text;

namespace Hystogram_MVC.Models
{
    class Hystogram
    {
        private int numbers;

        public int Numbers
        {
            get { return this.numbers; }
            set { this.numbers = value; }
        }

        public Hystogram(int numbers) 
        {
            this.Numbers = numbers;
        }

        public Hystogram() : this(0) { }

        public (double, double, double, double, double) CalculateSeparatedPercentages()
        {
            double p1 = 0, p2 = 0, p3 = 0, p4 = 0, p5 = 0;
            int num;

            for (int i = 0; i < this.Numbers; i++)
            {
                num = int.Parse(Console.ReadLine());

                if (num < 200)
                    p1++;
                else if (200 <= num && num <= 399)
                    p2++;
                else if (400 <= num && num <= 599)
                    p3++;
                else if (600 <= num && num <= 799)
                    p4++;
                else
                    p5++;
            }

            return (p1/this.Numbers*100, p2 / this.Numbers * 100, p3 / this.Numbers * 100, p4 / this.Numbers * 100, p5 / this.Numbers * 100);
        }
    }
}
