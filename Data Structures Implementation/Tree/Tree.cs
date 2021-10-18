using System;
using System.Collections.Generic;

namespace Tree
{
    class Tree<T>
    {
        private Node<T> root;
        private IList<Node<T>> children;

        public Node<T> Root
        {
            get => this.root;
            set => this.root = value != null ? value : throw new ArgumentNullException();
        }

        public IList<Node<T>> Children
        {
            get => this.children;
            set => this.children = value != null ? value : throw new ArgumentNullException();
        }

        public Tree()
        {
            this.Root = null;
        }

        public Tree(Node<T> root)
        {
            this.Root = root;
            this.Children = new List<Node<T>>();
        }

        public void PrintBFS()
        {
            Queue<Node<T>> visited = new Queue<Node<T>>();
            visited.Enqueue(this.Root);

            while (visited.Count != 0)
            {
                Node<T> current = visited.Dequeue();
                Console.Write(current.Data + " ");

                for (int i = 0; i < current.ChildrenCount; i++)
                {
                    visited.Enqueue(current.GetChild(i));
                }
            }
        }

        public void PrintDFS()
        {
            Stack<Node<T>> visited = new Stack<Node<T>>();
            visited.Push(this.Root);

            while (visited.Count != 0)
            {
                Node<T> current = visited.Pop();
                Console.Write(current.Data + " ");

                for (int i = 0; i < current.ChildrenCount; i++)
                {
                    visited.Push(current.GetChild(i));
                }
            }
        }
    }
}
