using System;
using System.Collections.Generic;
using System.Text;

namespace TransportMVC.Views
{
    class Display
    {
        public int Distance { get; set; }
        public string Time { get; set; }
        public double Total { get; set; }

        public Display()
        {
            Distance = 0;
            Time = "";
            Total = 0;
            GetValue();
        }

        private void GetValue()
        {
            Console.WriteLine("How far are you going to travel? (It should be in km!)");
            Distance = int.Parse(Console.ReadLine());
            Console.WriteLine("When are going to travel? (Type 'day' or 'night')");
            Time = Console.ReadLine();
        }

        public void ShowTotal()
        {
            Console.WriteLine($"The journey will cost you {Total:f2}");
        }
    }
}
