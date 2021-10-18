using System;
using System.Collections.Generic;

namespace Tree
{
    class Node<T>
    {
        private T data;
        private IList<Node<T>> children;
        private bool has_parent;

        public T Data
        {
            get => this.data;
            set => this.data = value != null ? value : throw new ArgumentNullException();
        }

        public IList<Node<T>> Children
        {
            get => this.children;
            set => this.children = value != null ? value : throw new ArgumentNullException();
        }

        public bool Has_Parent
        {
            get => this.has_parent;
            set => this.has_parent = value;
        }

        public int ChildrenCount
        {
            get => this.Children.Count;
        }

        public Node(T data)
        {
            this.Data = data;
            this.Children = new List<Node<T>>();
        }

        public void AddChild(Node<T> node)
        {
            if (node == null)
            {
                throw new ArgumentNullException();
            }

            if (node.Has_Parent)
            {
                throw new ArgumentException();
            }

            node.Has_Parent = true;
            this.Children.Add(node);
        }

        public Node<T> GetChild(int index)
        {
            return this.Children[index];
        }
    }
}
