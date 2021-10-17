using System;

namespace Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter node to start: ");
            int start = int.Parse(Console.ReadLine());

            int[,] graph = new int[,] {
                { 0, 1, 1, 1, 1 },
                { 1, 0, 0, 0, 1 },
                { 1, 0, 0, 1, 1 },
                { 1, 0, 1, 0, 0 },
                { 1, 1, 1, 0, 0 },
            };

            GraphMatrix gm = new GraphMatrix(graph);

            try
            {
                Console.Write($"BFS from node {start}: ");
                gm.PrintBFS(start);
                Console.WriteLine();

                Console.Write($"DFS drom node {start}: ");
                gm.PrintDFS(start);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
