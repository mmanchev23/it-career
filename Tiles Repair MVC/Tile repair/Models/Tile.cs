using System;
using System.Collections.Generic;
using System.Text;

namespace Tile_repair.Models
{
    class Tile
    {
        private double n;
        private double w;
        private double l;
        private double m;
        private double o;

        public double N
        {
            get { return this.n; }
            set { this.n = value; }
        }

        public double W
        {
            get { return this.w; }
            set { this.w = value; }
        }

        public double L
        {
            get { return this.l; }
            set { this.l = value; }
        }

        public double M
        {
            get { return this.m; }
            set { this.m = value; }
        }

        public double O
        {
            get { return this.o; }
            set { this.o = value; }
        }

        public Tile(double n, double w, double l, double m, double o)
        {
            this.N = n;
            this.W = w;
            this.L = l;
            this.M = m;
            this.O = o;
        }

        public Tile() : this(0, 0, 0, 0, 0) { }

        public (double, double) Calculate()
        {
            double totalArea = this.N * this.N;
            double benchArea = this.M * this.O;
            double coverageArea = totalArea - benchArea;
            double tileArea = this.W * this.L;
            double necessaryTiles = coverageArea / this.N;
            double necessaryTime = necessaryTiles * 0.2;

            return (necessaryTiles, necessaryTime);
        }
    }
}
