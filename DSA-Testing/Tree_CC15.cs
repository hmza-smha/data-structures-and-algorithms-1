using System;
using Xunit;
using data_structures_and_algorithms_1.binary_tree;
using data_structures_and_algorithms_1;
using System.Collections.Generic;

namespace DSA_Testing
{
    public class Tree_CC15
    {
        [Fact]
        public void Empty_Tree()
        {
            BinaryTree bt = new BinaryTree();
            Assert.Null(bt.Root);
        }

        [Fact]
        public void Single_Root_Node()
        {
            BinaryTree bt = new BinaryTree();
            bt.Root = new TreeNode(0);
            Assert.Equal(0, bt.Root.Value);
        }

        [Fact]
        public void BST_Left()
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.Add(new TreeNode(0));
            bst.Add(new TreeNode(-1));
            bst.Add(new TreeNode(1));

            Assert.Equal(-1, bst.Root.Left.Value);
        }

        [Fact]
        public void BST_Right()
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.Add(new TreeNode(0));
            bst.Add(new TreeNode(-1));
            bst.Add(new TreeNode(1));

            Assert.Equal(1, bst.Root.Right.Value);
        }

        [Fact]
        public void BST_PreOrder()
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.Add(new TreeNode(0));
            bst.Add(new TreeNode(-1));
            bst.Add(new TreeNode(1));

            List<int> list = new List<int>();
            list.Add(0);
            list.Add(-1);
            list.Add(1);

            Assert.Equal(list, bst.PreOrder(bst.Root));
        }

        [Fact]
        public void BST_InOrder()
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.Add(new TreeNode(0));
            bst.Add(new TreeNode(-1));
            bst.Add(new TreeNode(1));

            List<int> list = new List<int>();
            list.Add(-1);
            list.Add(0);
            list.Add(1);

            Assert.Equal(list, bst.InOrder(bst.Root));
        }

        [Fact]
        public void BST_PostOrder()
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.Add(new TreeNode(0));
            bst.Add(new TreeNode(-1));
            bst.Add(new TreeNode(1));

            List<int> list = new List<int>();
            list.Add(-1);
            list.Add(1);
            list.Add(0);

            Assert.Equal(list, bst.PostOrder(bst.Root));
        }

        [Theory]
        [InlineData(false, 10)]
        [InlineData(true, 0)]
        public void BST_Contains(bool expected, int input)
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.Add(new TreeNode(0));
            bst.Add(new TreeNode(-1));
            bst.Add(new TreeNode(1));

            Assert.Equal(expected, bst.Contains(input));
        }
    }
}
