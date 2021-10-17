using System;
using System.Collections.Generic;

namespace Graphs
{
    class GraphMatrix
    {
        private int[,] vertices;

        public int[,] Vertices
        {
            get => this.vertices;
            set => this.vertices = value;
        }

        public GraphMatrix(int[,] vertices)
        {
            this.vertices = vertices;
        }

        public void AddEdge(int i, int j, int weight)
        {
            vertices[i, j] = weight;
        }

        public void AddEdge(int i, int j)
        {
            vertices[i, j] = 1;
        }

        public void RemoveEdge(int i, int j)
        {
            vertices[i, j] = 0;
        }

        public bool HasEdge(int i, int j)
        {
            return vertices[i, j] != 0;
        }

        public IList<int> GetSuccessors(int i)
        {
            IList<int> successors = new List<int>();

            for (int j = 0; j < vertices.GetLength(1); j++)
            {
                if (vertices[i, j] != 0)
                {
                    successors.Add(j);
                }
            }
            return successors;
        }

        public void PrintBFS(int startV)
        {
            if (startV >= this.vertices.GetLength(0))
            {
                throw new ArgumentException("No such vertice!");
            }

            IList<int> visited = new List<int>();
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(startV);
            visited.Add(startV);

            while (queue.Count != 0)
            {
                int current = queue.Dequeue();
                Console.Write(current + " ");

                foreach (int child in this.GetSuccessors(current))
                {
                    if (!visited.Contains(child))
                    {
                        visited.Add(child);
                        queue.Enqueue(child);
                    }
                }
            }
        }

        public void PrintDFS(int startV)
        {
            if (startV >= this.vertices.GetLength(0))
            {
                throw new ArgumentException("No such vertice!");
            }

            IList<int> visited = new List<int>();
            Stack<int> stack = new Stack<int>();

            stack.Push(startV);
            visited.Add(startV);

            while (stack.Count != 0)
            {
                int current = stack.Pop();
                Console.Write(current + " ");

                foreach (int child in this.GetSuccessors(current))
                {
                    if (!visited.Contains(child))
                    {
                        visited.Add(child);
                        stack.Push(child);
                    }
                }
            }
        }
    }
}
