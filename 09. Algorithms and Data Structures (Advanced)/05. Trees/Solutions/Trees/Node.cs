using System;

namespace Trees
{
    class Node<T>
    {
        private T value;
        private bool has_parent;
        private Node<T> left_child;
        private Node<T> right_child;

        public T Value
        {
            get
            {
                return this.value;
            }
            set
            {
                if (this.value == null)
                {
                    throw new ArgumentNullException();
                }
                this.value = value;
            }
        }

        public Node<T> LeftChild
        {
            get => this.left_child;
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
                this.left_child = value;
            }
        }

        public Node<T> RightChild
        {
            get => this.right_child;
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
                this.right_child = value;
            }
        }

        public Node(T value, Node<T> leftChild, Node<T> rightChild)
        {
            this.Value = value;
            this.LeftChild = leftChild;
            this.RightChild = rightChild;
        }

        public Node(T value) : this(value, null, null) { }
    }
}
