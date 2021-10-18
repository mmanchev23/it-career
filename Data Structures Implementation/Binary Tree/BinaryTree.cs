using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree
{
    class BinaryTree<T>
    {
        private Node<T> root;

        public Node<T> Root
        {
            get => this.root;
            set => this.root = value != null ? value : throw new ArgumentNullException();
        }

        public BinaryTree(T value) : this(value, null, null) { }

        public BinaryTree(T data, BinaryTree<T> left, BinaryTree<T> right)
        {
            Node<T> left_child_node = left != null ? left.Root : null;
            Node<T> right_child_node = right != null ? right.Root : null;
            this.Root = new Node<T>(data, left_child_node, right_child_node);
        }

        private void PrintInOrder(Node<T> root)
        {
            if (root == null)
            {
                return;
            }

            PrintInOrder(root.Left);
            Console.Write(root.Data + " ");
            PrintInOrder(root.Right);
        }

        public void PrintInOrder()
        {
            PrintInOrder(this.Root);
            Console.WriteLine();
        }

        private void PrintPreorder(Node<T> root)
        {
            if (root == null)
            {
                return;
            }

            Console.Write(root.Data + " ");
            PrintPreorder(root.Left);
            PrintPreorder(root.Right);
        }

        public void PrintPreorder()
        {
            PrintPreorder(this.Root);
            Console.WriteLine();
        }

        private void PrintPostorder(Node<T> root)
        {
            if (root == null)
            {
                return;
            }

            PrintPostorder(root.Left);
            PrintPostorder(root.Right);
            Console.Write(root.Data + " ");
        }

        public void PrintPostorder()
        {
            PrintPostorder(this.Root);
            Console.WriteLine();
        }
    }
}
