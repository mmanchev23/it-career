using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magnetic_Tape
{
    public class Tape
    {
        private int probability;
        private int program;
        private double length;
        private double result;

        public int Probability
        {
            get => this.probability;
            set => this.probability = value;
        }

        public int Program
        {
            get => this.program;
            set => this.program = value;
        }

        public double Length
        {
            get => this.length;
            set => this.length = value;
        }

        public double Result
        {
            get => this.result;
            set => this.result = value;
        }

        public Tape(int probability, int program, double length, double result)
        {
            this.Probability = probability;
            this.Program = program;
            this.Length = length;
            this.Result = result;
        }
    }
}
