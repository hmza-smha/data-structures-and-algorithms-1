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
            
            TreeNode root = new TreeNode("0");
            TreeNode left = new TreeNode("1");
            TreeNode right = new TreeNode("2");
            TreeNode leftleft = new TreeNode("3");
            TreeNode leftright = new TreeNode("4");
            TreeNode rigthleft = new TreeNode("5");
            TreeNode rigthright = new TreeNode("6");

            root.Left = left;
            root.Right = right;

            left.Left = leftleft;
            left.Right = leftright;

            right.Left = rigthleft;
            right.Right = rigthright;

            List<string> list1 = BinaryTree.PreOrder(root);
            List<string> list2 = BinaryTree.InOrder(root);
            List<string> list3 = BinaryTree.PostOrder(root);

            foreach (string e in list1)
            {
                Console.WriteLine(e);
            }

        }
    }
}
