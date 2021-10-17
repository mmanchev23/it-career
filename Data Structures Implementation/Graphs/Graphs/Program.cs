using System;

namespace Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Main 1
            /*Console.Write("Enter node to start: ");
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
            }*/

            // Main 2
            /*Graph<int> g = new Graph<int>();
            Node<int> n1 = new Node<int>(1);
            Node<int> n2 = new Node<int>(2);
            Node<int> n3 = new Node<int>(3);
            Node<int> n4 = new Node<int>(4);
            Node<int> n5 = new Node<int>(5);
            Node<int> n6 = new Node<int>(6);
            g.AddNode(n1);
            g.AddNode(n2);
            g.AddNode(n3);
            g.AddNode(n4);
            g.AddNode(n5);
            g.AddNode(n6);
            g.AddEdge(n1, n2);
            g.AddEdge(n1, n3);
            g.AddEdge(n2, n4);
            g.AddEdge(n3, n5);
            g.AddEdge(n3, n6);

            g.BFS(n1);
            Console.WriteLine();
            g.DFS(n1);*/
        }
    }
}
