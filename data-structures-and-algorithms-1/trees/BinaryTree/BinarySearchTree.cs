using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_and_algorithms_1.binary_tree
{
    public class BinarySearchTree : BinaryTree
    {
        public void Add(BinaryTreeNode node)
        {
            AddNewNode(Root, node);
        }

        private void AddNewNode(BinaryTreeNode root, BinaryTreeNode new_node)
        {
            if(Root == null)
            {
                Root = new_node;
                return;
            }

            if(new_node.Value < root.Value)
            {
                if(root.Left != null)
                    AddNewNode(root.Left, new_node);
                else
                    root.Left = new_node;
            }
            else
            {
                if(root.Right != null)
                    AddNewNode(root.Right, new_node);
                else
                    root.Right = new_node;
            }

        }

        public bool Contains(int value)
        {
            return ContainsValue(Root, value);
        }

        private bool ContainsValue(BinaryTreeNode root, int value)
        {
            if( root == null)
                return false;

            if (root.Value == value)
                return true;

            if (value < root.Value)
                return ContainsValue(root.Left, value);
            else
                return ContainsValue(root.Right, value);

        }
    }
}
