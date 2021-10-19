using System;
using System.Collections.Generic;
using System.Text;
using TransportMVC.Models;
using TransportMVC.Views;

namespace TransportMVC.Controllers
{
    class TransportPriceController
    {
        private Transport transport;
        private Display display;

        public TransportPriceController()
        {
            display = new Display();
            transport = new Transport(display.Distance, display.Time);
            display.Total = transport.CalculateTotal();
            display.ShowTotal();
        }
    }
}
