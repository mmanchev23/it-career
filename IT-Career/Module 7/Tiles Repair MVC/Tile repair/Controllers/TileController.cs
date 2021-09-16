using System;
using System.Collections.Generic;
using System.Text;
using Tile_repair.Models;
using Tile_repair.Views;

namespace Tile_repair.Controllers
{
    class TileController
    {
        private Display display;
        private Tile tile;

        public TileController()
        {
            display = new Display();
            tile = new Tile(display.N, display.W, display.L, display.M, display.O);

            display.Output = tile.Calculate();

            display.PrintOutput();
        }
    }
}
