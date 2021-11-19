using System;

namespace Trees
{
    class BinaryTree<T>
    {
        private Node<T> root;

        public Node<T> Root
        {
            get
            {
                return this.root;
            }
        }

        public BinaryTree(T value, BinaryTree<T> left_child, BinaryTree<T> right_child)
        {
            Node<T> left_child_node = left_child != null ? left_child.root : null;
            Node<T> right_child_node = right_child != null ? right_child.root : null;
            this.root = new Node<T>(value, left_child_node, right_child_node);
        }

        public BinaryTree(T value) : this(value, null, null) { }

        private void PrintInorder(Node<T> root)
        {
            if (root == null)
            {
                return;
            }

            PrintInorder(root.LeftChild);
            Console.Write(root.Value + " ");
            PrintInorder(root.RightChild);
        }

        public void PrintInorder()
        {
            PrintInorder(this.Root);
            Console.WriteLine();
        }

        private void PrintPreorder(Node<T> root)
        {
            if (root == null)
            {
                return;
            }

            Console.Write(root.Value + " ");
            PrintPreorder(root.LeftChild);
            PrintPreorder(root.RightChild);
        }

        public void PrintPreorder()
        {
            PrintPreorder(this.root);
            Console.WriteLine();
        }

        private void PrintPostorder(Node<T> root)
        {
            if (root == null)
            {
                return;
            }

            PrintPostorder(root.LeftChild);
            PrintPostorder(root.RightChild);
            Console.Write(root.Value + " ");
        }

        public void PrintPostorder()
        {
            PrintPostorder(this.root);
            Console.WriteLine();
        }
    }
}
