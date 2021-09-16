using System;
using System.Collections.Generic;
using System.Linq;

namespace Jumping_on_the_Clouds
{
    class Program
    {
        public static int jumpingOnClouds(List<int> list)
        {
            int count = 0;
            int i = 0;

            while (i < list.Count - 1)
            {
                if (i + 2 < list.Count && list[i + 2] != 1)
                {
                    count++;
                    i += 2;
                }
                else
                {
                    count++;
                    i++;
                }
            }

            return count;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            jumpingOnClouds(list);
        }
    }
}
