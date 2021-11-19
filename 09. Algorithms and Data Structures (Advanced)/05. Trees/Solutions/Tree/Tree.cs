using System;
using System.Collections.Generic;

namespace Tree
{
    public class Tree<T> where T : IComparable<T>
    {
        private Tree_Node<T> root;

        public Tree(T value)
        {
            this.root = new Tree_Node<T>(value);
        }

        public Tree(T value, params Tree<T>[] children) : this(value)
        {
            foreach (Tree<T> child in children)
            {
                this.root.AddChild(child.root);
            }
        }

        public Tree_Node<T> Root
        {
            get
            {
                return this.root;
            }
        }

        // Breadth-First-Search - (BFS)
        public void PrintBFS()
        {
            Queue<Tree_Node<T>> visited = new Queue<Tree_Node<T>>();
            visited.Enqueue(this.root);

            while (visited.Count != 0)
            {
                Tree_Node<T> current = visited.Dequeue();
                Console.Write(current.Data + " ");
                for (int i = 0; i < current.ChildrenCount; i++)
                {
                    visited.Enqueue(current.GetChild(i));
                }
            }
        }

        // Depth-First-Search (DFS)
        public void PrintDFS()
        {
            Stack<Tree_Node<T>> visited = new Stack<Tree_Node<T>>();
            visited.Push(this.root);

            while (visited.Count != 0)
            {
                Tree_Node<T> current = visited.Pop();
                Console.Write(current.Data + " ");
                for (int i = 0; i < current.ChildrenCount; i++)
                {
                    visited.Push(current.GetChild(i));
                }
            }
        }
    }
}
