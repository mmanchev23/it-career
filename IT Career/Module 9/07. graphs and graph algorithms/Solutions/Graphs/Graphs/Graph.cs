using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    class Graph<T>
    {
        private Dictionary<Node<T>, List<Node<T>>> adj;

        public Graph()
        {
            adj = new Dictionary<Node<T>, List<Node<T>>>();
        }

        public void AddNode(Node<T> node)
        {
            this.adj[node] = new List<Node<T>>();
        }

        public void AddNode(T value)
        {
            this.adj[new Node<T>(value)] = new List<Node<T>>();
        }

        public void AddEdge(Node<T> source, Node<T> dest)
        {
            if (!adj.ContainsKey(source) || !adj.ContainsKey(dest))
            {
                throw new ArgumentException("Nodes not existing!");
            }
            if (adj[source].Contains(dest))
            {
                throw new Exception("Edge already exist!");
            }
            adj[source].Add(dest);
        }

        public void RemoveEdge(Node<T> source, Node<T> dest)
        {
            if (!adj.ContainsKey(source) || !adj.ContainsKey(dest))
            {
                throw new ArgumentException("Invalid nodes!");
            }
            adj[source].Remove(dest);
        }

        public void BFS(Node<T> start)
        {
            if (!adj.ContainsKey(start))
            {
                throw new ArgumentException("Start node not exists!");
            }
            List<Node<T>> visited = new List<Node<T>>();
            Queue<Node<T>> queue = new Queue<Node<T>>();
            queue.Enqueue(start);
            visited.Add(start);
            while (queue.Count != 0)
            {
                Node<T> current = queue.Dequeue();
                foreach (Node<T> node in adj[current])
                {
                    if (!visited.Contains(node))
                    {
                        visited.Add(node);
                        queue.Enqueue(node);
                    }
                }
                Console.Write("{0} ", current);
            }
        }

        public void DFS(Node<T> start)
        {
            if (!adj.ContainsKey(start))
            {
                throw new ArgumentException("Start node not exists!");
            }
            List<Node<T>> visited = new List<Node<T>>();
            Stack<Node<T>> queue = new Stack<Node<T>>();
            queue.Push(start);
            visited.Add(start);
            while (queue.Count != 0)
            {
                Node<T> current = queue.Pop();
                foreach (Node<T> node in adj[current])
                {
                    if (!visited.Contains(node))
                    {
                        visited.Add(node);
                        queue.Push(node);
                    }
                }
                Console.Write("{0} ", current);
            }
        }
    }
}
