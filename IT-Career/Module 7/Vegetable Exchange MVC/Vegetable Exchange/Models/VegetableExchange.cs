using System;
using System.Collections.Generic;
using System.Text;

namespace Vegetable_Exchange.Models
{
    class VegetableExchange
    {
        private double prizeVegetables;
        private double prizeFruits;
        private double kgVegetables;
        private double kgFruits;

        public double PrizeVegetables
        {
            get { return this.prizeVegetables; }
            set { this.prizeVegetables = value; }
        }

        public double PrizeFruits
        {
            get { return this.prizeFruits; }
            set { this.prizeFruits = value; }
        }

        public double KgVegetables
        {
            get { return this.kgVegetables; }
            set { this.kgVegetables = value; }
        }

        public double KgFruits
        {
            get { return this.kgFruits; }
            set { this.kgFruits = value; }
        }

        public VegetableExchange(double prizeVegetables, double prizeFruits, double kgVegetables, double kgFruits)
        {
            this.PrizeVegetables = prizeVegetables;
            this.PrizeFruits = prizeFruits;
            this.KgVegetables = kgVegetables;
            this.KgFruits = kgFruits;
        }

        public VegetableExchange() : this(0, 0, 0, 0) { }

        public double CalculateTotal()
        {
            return (PrizeVegetables * KgVegetables + PrizeFruits * KgFruits) / 1.94;
        }
    }
}
