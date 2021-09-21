using System;
using System.Linq;
using System.Collections.Generic;

namespace Sales_by_Match
{
    class Program
    {
        public static int sockMerchant(int n, List<int> list)
        {
            int pairs = 0;

            for (int i = 0; i < n; i++)
            {
                if (list[i] != 0)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (list[i] == list[j])
                        {
                            pairs++;
                            list[j] = 0;
                            break;
                        }
                    }
                }
            }

            return pairs;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            sockMerchant(n, list);
        }
    }
}
