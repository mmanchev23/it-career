using System;

namespace Counting_Valleys
{
    class Program
    {
        public static int countingValleys(int steps, string path)
        {
            int current_level = 0;
            int valleys = 0;

            for (int i = 0; i < steps; i++)
            {
                if (path[i] == 'U')
                {
                    current_level++;
                    if (current_level == 0)
                    {
                        valleys++;
                    }
                }
                else
                {
                    current_level--;
                }
            }

            return valleys;
        }

        static void Main(string[] args)
        {
            int steps = int.Parse(Console.ReadLine());
            string path = Console.ReadLine();

            countingValleys(steps, path);
        }
    }
}
