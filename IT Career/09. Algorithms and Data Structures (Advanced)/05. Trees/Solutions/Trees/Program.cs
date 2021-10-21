using System;

namespace Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> binTree =
                new BinaryTree<int>(14,
                new BinaryTree<int>(19,
                new BinaryTree<int>(23),
                new BinaryTree<int>(6,
                new BinaryTree<int>(10),
                new BinaryTree<int>(21))),
                new BinaryTree<int>(15,
                new BinaryTree<int>(3),
                null));


            Console.Write("Inorder: ");
            binTree.PrintInorder();

            Console.Write("Preorder: ");
            binTree.PrintPreorder();

            Console.Write("Postorder: ");
            binTree.PrintPostorder();
        }
    }
}
