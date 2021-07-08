using System;
using System.Collections.Generic;
using System.Text;
using Hystogram_MVC.Models;
using Hystogram_MVC.Views;

namespace Hystogram_MVC.Controllers
{
    class HystogramController
    {
        private Display display;
        private Hystogram hystogram;

        public HystogramController()
        {
            display = new Display();
            hystogram = new Hystogram(display.Input);

            display.Percentages = hystogram.CalculateSeparatedPercentages();

            display.PrintOutput();
        }
    }
}
