using data_structures_and_algorithms_1.binary_tree;
using data_structures_and_algorithms_1.trees.tree_intersection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using data_structures_and_algorithms_1;
using Xunit;

namespace DSA_Testing
{
    public class TreeIntersection_CC32
    {
        [Fact]
        public void Test1()
        {
            TreeIntersection ti = new TreeIntersection();

            BinarySearchTree tree1 = new BinarySearchTree();
            BinarySearchTree tree2 = new BinarySearchTree();

            tree1.Add(new BinaryTreeNode(1));
            tree1.Add(new BinaryTreeNode(2));
            tree1.Add(new BinaryTreeNode(3));

            tree2.Add(new BinaryTreeNode(1));
            tree2.Add(new BinaryTreeNode(5));
            tree2.Add(new BinaryTreeNode(2));

            Assert.Equal(new List<int> { 1, 2 }, ti.GetIntersection(tree1, tree2));

        }

        [Fact]
        public void Test2()
        {
            TreeIntersection ti = new TreeIntersection();

            BinarySearchTree tree1 = new BinarySearchTree();
            BinarySearchTree tree2 = new BinarySearchTree();

            tree1.Add(new BinaryTreeNode(1));
            tree1.Add(new BinaryTreeNode(2));
            tree1.Add(new BinaryTreeNode(3));
            tree1.Add(new BinaryTreeNode(5));
            tree1.Add(new BinaryTreeNode(9));

            tree2.Add(new BinaryTreeNode(5));
            tree2.Add(new BinaryTreeNode(2));
            tree2.Add(new BinaryTreeNode(20));

            Assert.Equal(new List<int> { 5, 2 }, ti.GetIntersection(tree1, tree2));

        }
    }
}
