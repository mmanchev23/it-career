using System;

namespace Binary_Tree
{
    class Node<T>
    {
        private T data;
        private bool has_parent;
        private Node<T> left;
        private Node<T> right;


        public T Data
        {
            get => this.data;
            set => this.data = value != null ? value : throw new ArgumentNullException();
        }

        public bool Has_Parent
        {
            get => this.has_parent;
            set => this.has_parent = value;
        }

        public Node<T> Left
        {
            get
            {
                return this.left;
            }
            set
            {
                if (value == null)
                {
                    return;
                }

                if (value.has_parent)
                {
                    throw new ArgumentException();
                }

                value.has_parent = true;
                this.left = value;
            }
        }

        public Node<T> Right
        {
            get
            {
                return this.right;
            }
            set
            {
                if (value == null)
                {
                    return;
                }

                if (value.has_parent)
                {
                    throw new ArgumentException();
                }

                value.has_parent = true;
                this.right = value;
            }
        }

        public Node(T value) : this(value, null, null) { }

        public Node(T data, Node<T> left, Node<T> right)
        {
            this.Data = data;
            this.Left = left;
            this.Right = right;
        }
    }
}
