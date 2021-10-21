using System;

namespace Binary_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Binary_Tree<int> binTree =
                new Binary_Tree<int>(14,
                new Binary_Tree<int>(19,
                new Binary_Tree<int>(23),
                new Binary_Tree<int>(6,
                new Binary_Tree<int>(10),
                new Binary_Tree<int>(21))),
                new Binary_Tree<int>(15,
                new Binary_Tree<int>(3),
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
