using System;
using System.Collections.Generic;
using data_structures_and_algorithms_1;
using data_structures_and_algorithms_1.binary_tree;

namespace data_structures_and_algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Data Structures & Algorithms!");

            /*
                   0
                1     2
              3   4 5   6

             */

            BinarySearchTree bst = new BinarySearchTree();

            bst.Add(new TreeNode(10));
            bst.Add(new TreeNode(8));
            bst.Add(new TreeNode(13));
            bst.Add(new TreeNode(7));
            bst.Add(new TreeNode(9));
            bst.Add(new TreeNode(12));
            bst.Add(new TreeNode(14));

            Console.WriteLine(bst.Contains(81));
            Console.WriteLine(bst.Root.Left.Value);

            //List<int> list1 = bst.PreOrder(bst.Root);

            //foreach (int e in list1)
            //{
            //    Console.Write(e);
            //}

            ////BinaryTree binaryTree = new BinaryTree();

            ////TreeNode root = new TreeNode(0);
            ////TreeNode left = new TreeNode(1);
            ////TreeNode right = new TreeNode(2);
            ////TreeNode leftleft = new TreeNode(3);
            ////TreeNode leftright = new TreeNode(4);
            ////TreeNode rigthleft = new TreeNode(5);
            ////TreeNode rigthright = new TreeNode(6);

            ////root.Left = left;
            ////root.Right = right;

            ////left.Left = leftleft;
            ////left.Right = leftright;

            ////right.Left = rigthleft;
            ////right.Right = rigthright;

            ////List<int> list1 = binaryTree.PreOrder(root);
            ////List<int> list2 = binaryTree.InOrder(root);
            ////List<int> list3 = binaryTree.PostOrder(root);

            ////foreach (int e in list1)
            ////{
            ////    Console.Write(e);
            ////}
            ////Console.WriteLine();
            ////foreach (int e in list2)
            ////{
            ////    Console.Write(e);
            ////}
            ////Console.WriteLine();
            ////foreach (int e in list3)
            ////{
            ////    Console.Write(e);
            ////}

        }
    }
}
