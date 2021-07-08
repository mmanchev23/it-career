using System;
using System.Collections.Generic;
using System.Text;

namespace Vegetable_Exchange.Views
{
    class Display
    {
        public double PrizeVegetables { get; set; }
        public double PrizeFruits { get; set; }
        public double KgVegetables { get; set; }
        public double KgFruits { get; set; }
        public double Output { get; set; }

        public Display()
        {
            this.PrizeVegetables = 0.00;
            this.PrizeFruits = 0.00;
            this.KgVegetables = 0.00;
            this.PrizeFruits = 0.00;
            this.Output = 0.00;
            GetValues();
        }

        private void GetValues()
        {
            Console.Write("Prize of the vegetables: ");
            this.PrizeVegetables = double.Parse(Console.ReadLine());
            Console.Write("Prize of the fruits: ");
            this.PrizeFruits = double.Parse(Console.ReadLine());
            Console.Write("Kg of the vegetables: ");
            this.KgVegetables = double.Parse(Console.ReadLine());
            Console.Write("Kg of the fruits: ");
            this.KgFruits = double.Parse(Console.ReadLine());
        }

        public void PrintOutput()
        {
            Console.WriteLine();
            Console.WriteLine($"{this.Output} euro -> {this.Output * 1.94} leva");
        }
    }
}
