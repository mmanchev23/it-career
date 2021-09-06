using System;
using System.Linq;

namespace Sets
{
    class Program
    {
        private static void CalculateSets(int[] universe, int[][] subsets)
        {
            subsets = subsets.OrderByDescending(x => x.Length).ToArray();
            Console.WriteLine();
            for (int i = 0; i < subsets.Length; i++)
            {
                for (int j = 0; j < subsets[i].Length; j++)
                {
                    if (universe.Contains(subsets[i][j]))
                    {
                        universe = universe.Where(val => val != subsets[i][j]).ToArray();
                        Console.WriteLine("{ " + string.Join(", ", subsets[i]) + " }");
                        subsets = subsets.Where(val => val != subsets[i]).ToArray();
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int[] universe = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            int[][] subsets = new int[n][];

            for (int i = 0; i < n; i++)
            {
                subsets[i] = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            }

            CalculateSets(universe, subsets);
        }
    }
}

/*
Input 1
1, 3, 5, 7, 9, 11, 20, 30, 40
6
20 
1, 5, 20, 30
3, 7, 20, 30, 40
9, 30
11, 20, 30, 40
3, 7, 40

{ 3, 7, 20, 30, 40 } 
{ 1, 5, 20, 30 } 
{ 9, 30 } 
{ 11, 20, 30, 40 }


Input 2
1, 2, 3, 4, 5
4
1
2, 4
5
3

{ 2, 4 } 
{ 1 } 
{ 5 } 
{ 3 }


Input 3
1, 2, 3, 4, 5
4
1, 2, 3, 4, 5 
2, 3, 4, 5 
5 
3

{ 1, 2, 3, 4, 5 }
*/
