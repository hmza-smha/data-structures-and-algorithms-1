using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_and_algorithms_1.binary_tree
{
    public class BinaryTree
    {
        public TreeNode Root;
        public static List<string> list = new List<string>();
        static BinaryTree()
        {
            list = new List<string>();
        }

        public static List<string> PreOrder(TreeNode root)
        {
            
            if(root == null)
                return null;

            list.Add(root.Value);

            PreOrder(root.Left);
            PreOrder(root.Right);

            return list;
        }

        public static List<string> InOrder(TreeNode root)
        {

            if (root == null)
                return null;

            InOrder(root.Left);

            list.Add(root.Value);
            
            InOrder(root.Right);

            return list;
        }

        public static List<string> PostOrder(TreeNode root)
        {

            if (root == null)
                return null;

            PostOrder(root.Left);
            PostOrder(root.Right);

            list.Add(root.Value);

            return list;
        }
    }
}
