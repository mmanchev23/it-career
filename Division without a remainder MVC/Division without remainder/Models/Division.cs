using System;
using System.Collections.Generic;
using System.Text;

namespace Division_without_remainder.Models
{
    class Division
    {
        private int numbers;

        public int Numbers
        {
            get { return this.numbers; }
            set { this.numbers = value; }
        }

        public Division(int numbers)
        {
            this.Numbers = numbers;
        }

        public Division() : this(0) { }

        public (double p1, double p2, double p3) CalculatePercentages()
        {
            double p1 = 0.0, p2 = 0.0, p3 = 0.0;
            int num;

            for (int i = 0; i < this.Numbers; i++)
            {
                num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                    p1++;

                if (num % 3 == 0)
                    p2++;

                if (num % 4 == 0)
                    p3++;
            }

            return (p1 / 10 * 100, p2 / 10 * 100, p3 / 10 * 100);
        }
    }
}
