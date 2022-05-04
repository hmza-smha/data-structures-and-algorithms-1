using System;
using System.Collections.Generic;
using data_structures_and_algorithms_1;
using data_structures_and_algorithms_1.binary_tree;
using data_structures_and_algorithms_1.trees;

namespace data_structures_and_algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Data Structures & Algorithms!");

            //Tree tree = new Tree();

            //TreeNode n1 = new TreeNode("1");
            //TreeNode n2 = new TreeNode("2");
            //TreeNode n3 = new TreeNode("3");
            //TreeNode n4 = new TreeNode("4");
            //TreeNode n5 = new TreeNode("5");
            //TreeNode n6 = new TreeNode("6");
            //TreeNode n7 = new TreeNode("7");
            //TreeNode n8 = new TreeNode("8");
            //TreeNode n9 = new TreeNode("9");
            //TreeNode n10 = new TreeNode("10");

            //n2.Children.Add(n5);
            //n2.Children.Add(n6);

            //n3.Children.Add(n7);

            //n4.Children.Add(n8);
            //n4.Children.Add(n9);
            //n4.Children.Add(n10);

            //n1.Children.Add(n2);
            //n1.Children.Add(n3);
            //n1.Children.Add(n4);

            //tree.Root = n1;

            ////foreach (TreeNode n in tree.BFS())
            ////{
            ////    Console.WriteLine(n.Value);
            ////}

            //Tree other = tree.FizzBuzz();

            //foreach (TreeNode n in other.BFS())
            //{
            //    Console.WriteLine(n.Value);
            //}

            //Tree t = new Tree();

            //TreeNode n15 = new TreeNode("15");
            //TreeNode n1 = new TreeNode("1");
            //TreeNode n5 = new TreeNode("5");
            //TreeNode n3 = new TreeNode("3");
            //TreeNode n20 = new TreeNode("20");
            //TreeNode n33 = new TreeNode("3");
            //TreeNode n11 = new TreeNode("1");
            //TreeNode n9 = new TreeNode("9");
            //TreeNode n30 = new TreeNode("30");

            //t.Root = n15;

            //n15.Children.Add(n1);
            //n15.Children.Add(n5);
            //n15.Children.Add(n3);

            //n1.Children.Add(n20);
            //n1.Children.Add(n33);

            //n5.Children.Add(n11);

            //n3.Children.Add(n30);
            //n3.Children.Add(n9);

            //Tree fizz = t.FizzBuzz();

            //foreach (TreeNode n in t.BFS())
            //{
            //    Console.Write(n.Value + ", ");
            //}
            //Console.WriteLine();
            //foreach (TreeNode n in fizz.BFS())
            //{
            //    Console.Write(n.Value + ", ");
            //}

            BinarySearchTree bst = new BinarySearchTree();

            bst.Add(new BinaryTreeNode(10));
            bst.Add(new BinaryTreeNode(7));
            bst.Add(new BinaryTreeNode(15));
            bst.Add(new BinaryTreeNode(5));
            bst.Add(new BinaryTreeNode(9));
            bst.Add(new BinaryTreeNode(13));
            bst.Add(new BinaryTreeNode(17));

            List<int> pre = bst.PreOrder(bst.Root);
            List<int> inn = bst.InOrder(bst.Root);
            List<int> post = bst.PostOrder(bst.Root);

            foreach (var e in post)
            {
                Console.WriteLine(e);
            }

        }
    }
}
