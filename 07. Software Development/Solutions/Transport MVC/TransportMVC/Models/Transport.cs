using System;
using System.Collections.Generic;
using System.Text;

namespace TransportMVC.Models
{
    class Transport
    {
        private int distance;
        private string time;

        public int Distance
        {
            get { return this.distance; }
            set { this.distance = value; }
        }

        public string Time
        { 
            get { return this.time; }
            set { this.time = value; }
        }

        public Transport(int distance, string time)
        {
            this.Distance = distance;
            this.Time = time;
        }

        public double CalculateTotal() 
        {
            //Taxi
            if (Distance < 20)
                if (Time == "day")
                    return 0.7 + Distance * 0.79;
                else
                    return 0.7 + Distance * 0.9;
            //Bus
            else if (Distance > 20 && Distance < 100)
                return 0.09 * Distance;
            //Train
            else
                return 0.06 * Distance;
        }
    }
}
