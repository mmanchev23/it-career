using System;

namespace Binary_Tree
{
    class Binary_Tree<T> where T : IComparable<T>
    {
        private Binary_Tree_Node<T> root;

        public Binary_Tree_Node<T> Root
        {
            get
            {
                return this.root;
            }
        }

        public Binary_Tree(T value, Binary_Tree<T> leftChild, Binary_Tree<T> rightChild)
        {
            Binary_Tree_Node<T> leftChildNode = leftChild != null ? leftChild.root : null;
            Binary_Tree_Node<T> rightChildNode = rightChild != null ? rightChild.root : null;
            this.root = new Binary_Tree_Node<T>(value, leftChildNode, rightChildNode);
        }

        public Binary_Tree(T value) : this(value, null, null) { }

        private void PrintInorder(Binary_Tree_Node<T> root)
        {
            if (root == null)
            {
                return;
            }

            PrintInorder(root.LeftChild);
            Console.Write(root.Data + " ");
            PrintInorder(root.RightChild);
        }

        public void PrintInorder()
        {
            PrintInorder(this.Root);
            Console.WriteLine();
        }

        private void PrintPreorder(Binary_Tree_Node<T> root)
        {
            if (root == null)
            {
                return;
            }
            Console.Write(root.Data + " ");
            PrintPreorder(root.LeftChild);
            PrintPreorder(root.RightChild);
        }

        public void PrintPreorder()
        {
            PrintPreorder(this.root);
            Console.WriteLine();
        }

        private void PrintPostorder(Binary_Tree_Node<T> root)
        {
            if (root == null)
            {
                return;
            }
            PrintPostorder(root.LeftChild);
            PrintPostorder(root.RightChild);
            Console.Write(root.Data + " ");
        }

        public void PrintPostorder()
        {
            PrintPostorder(this.root);
            Console.WriteLine();
        }
    }
}
