using System;
using System.Collections.Generic;

namespace Tree
{
    public class Tree_Node<T> where T : IComparable<T>
    {
        private T data;
        private IList<Tree_Node<T>> children;
        private bool has_parent;

        public T Data
        {
            get => this.data;
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }

                this.data = value;
            }
        }

        public int ChildrenCount
        {
            get => this.children.Count;
        }

        public Tree_Node(T value)
        {
            this.Data = value;
            this.children = new List<Tree_Node<T>>();
        }

        public void AddChild(Tree_Node<T> child)
        {
            if (child == null)
            {
                throw new ArgumentNullException();
            }

            if (child.has_parent)
            {
                throw new ArgumentException();
            }

            child.has_parent = true;
            this.children.Add(child);
        }

        public Tree_Node<T> GetChild(int index)
        {
            return this.children[index];
        }
    }
}
