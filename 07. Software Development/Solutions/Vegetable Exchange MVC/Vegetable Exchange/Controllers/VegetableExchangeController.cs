using System;
using System.Collections.Generic;
using System.Text;
using Vegetable_Exchange.Models;
using Vegetable_Exchange.Views;

namespace Vegetable_Exchange.Controllers
{
    class VegetableExchangeController
    {
        private Display display;
        private VegetableExchange vegetableExchange;

        public VegetableExchangeController()
        {
            display = new Display();
            vegetableExchange = new VegetableExchange(display.PrizeVegetables, display.PrizeFruits, display.KgVegetables, display.KgFruits);

            display.Output = vegetableExchange.CalculateTotal();

            display.PrintOutput();
        }
    }
}
