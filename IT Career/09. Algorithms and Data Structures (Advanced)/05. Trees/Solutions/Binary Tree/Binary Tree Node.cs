using System;

namespace Binary_Tree
{
    public class Binary_Tree_Node<T> where T : IComparable<T>
    {
        private T data;
        private bool has_parent;
        private Binary_Tree_Node<T> left_child;
        private Binary_Tree_Node<T> right_child;

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

        public Binary_Tree_Node<T> LeftChild
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

        public Binary_Tree_Node<T> RightChild
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

        public Binary_Tree_Node(T data, Binary_Tree_Node<T> left_child, Binary_Tree_Node<T> right_child)
        {
            this.Data = data;
            this.LeftChild = left_child;
            this.RightChild = right_child;
        }

        public Binary_Tree_Node(T value) : this(value, null, null) { }
    }
}
