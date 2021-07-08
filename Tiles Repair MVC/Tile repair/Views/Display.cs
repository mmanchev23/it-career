using System;
using System.Collections.Generic;
using System.Text;

namespace Tile_repair.Views
{
    class Display
    {
        public double N { get; set; }
        public double W { get; set; }
        public double L { get; set; }
        public double M { get; set; }
        public double O { get; set; }
        public (double tiles, double time) Output { get; set; }

        public Display()
        {
            N = 0.0;
            W = 0.0;
            L = 0.0;
            M = 0.0;
            O = 0.0;
            Output = (0.0, 0.0);
            GetValues();
        }

        private void GetValues()
        {
            this.N = int.Parse(Console.ReadLine()); 
            this.W = int.Parse(Console.ReadLine());
            this.L = int.Parse(Console.ReadLine());
            this.M = int.Parse(Console.ReadLine());
            this.O = int.Parse(Console.ReadLine());
        }

        public void PrintOutput()
        {
            Console.WriteLine($"\n{this.Output.tiles}\n{this.Output.time}");
        }
    }
}
