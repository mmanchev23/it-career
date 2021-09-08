using System;
using System.Collections.Generic;
using System.Text;
using Division_without_remainder.Models;
using Division_without_remainder.Views;

namespace Division_without_remainder.Controllers
{
    class DivisonController
    {
        private Display display;
        private Division division;

        public DivisonController()
        {
            display = new Display();
            division = new Division(display.Input);

            display.Output = division.CalculatePercentages();

            display.PrintOutput();
        }
    }
}
