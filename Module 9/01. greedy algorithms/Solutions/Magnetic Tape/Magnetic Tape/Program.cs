using System;
using System.Linq;

namespace Magnetic_Tape
{
    class Program
    {
        public static void CalculateTapes(Tape[] tapes)
        {
            for (int i = 0; i < tapes.Length; i++)
            {
                tapes[i].Result = tapes[i].Length / tapes[i].Program;
            }

            tapes = tapes.OrderByDescending(tape => tape.Result).ToArray();

            foreach(var tape in tapes)
            {
                Console.Write($"{tape.Probability} ");
            }
        }

        static void Main(string[] args)
        {
            Console.Write("How many tapes are there? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            string[] input;
            Tape[] tapes = new Tape[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Tape #{i + 1}: ");
                input = Console.ReadLine().Split(" ");
                tapes[i] = new Tape(int.Parse(input[0]), int.Parse(input[1]), double.Parse(input[2]), 0);
            }

            CalculateTapes(tapes);
        }
    }
}
/*
4
1 1 0.3
2 3 0.1
3 2 0.5
4 4 0.2

1 3 4 2
*/
