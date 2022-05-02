using data_structures_and_algorithms_1;
using data_structures_and_algorithms_1.binary_tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DSA_Testing
{
    public class BradthFirst_CC17
    {
        [Fact]
        public void Empty_Tree()
        {
            BinarySearchTree bst = new BinarySearchTree();
            Assert.Throws<Exception>(() => bst.BreadthFirst(bst.Root));
        }

        [Fact]
        public void Breadth_First_Result()
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.Add(new TreeNode(10));
            bst.Add(new TreeNode(5));
            bst.Add(new TreeNode(15));
            bst.Add(new TreeNode(3));
            bst.Add(new TreeNode(7));
            bst.Add(new TreeNode(13));
            bst.Add(new TreeNode(16));

            List<int> expectedResult = new List<int>();
            expectedResult.Add(10);
            expectedResult.Add(5);
            expectedResult.Add(15);
            expectedResult.Add(3);
            expectedResult.Add(7);
            expectedResult.Add(13);
            expectedResult.Add(16);

            Assert.Equal(expectedResult, bst.BreadthFirst(bst.Root));
        }
    }
}
