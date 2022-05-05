using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_and_algorithms_1.binary_tree
{
    public class BinaryTree
    {
        public BinaryTreeNode Root;

        public List<int> PreOrder(BinaryTreeNode root)
        {
            if (root == null)
                throw new Exception("Tree is empty!");

            List<int> list = new List<int>();
            return GetPreOrderList(list, root);
        }

        private List<int> GetPreOrderList(List<int> list, BinaryTreeNode root)
        {
            
            if(root == null)
                return null;

            list.Add(root.Value);

            GetPreOrderList(list, root.Left);
            GetPreOrderList(list, root.Right);

            return list;
        }

        public List<int> InOrder(BinaryTreeNode root)
        {
            if (root == null)
                throw new Exception("Tree is empty!");

            List<int> list = new List<int>();
            return GetInOrderList(list, root);
        }

        private List<int> GetInOrderList(List<int> list, BinaryTreeNode root)
        {

            if (root == null)
                return null;

            GetInOrderList(list, root.Left);

            list.Add(root.Value);

            GetInOrderList(list, root.Right);

            return list;
        }
        public List<int> PostOrder(BinaryTreeNode root)
        {
            if (root == null)
                throw new Exception("Tree is empty!");

            List<int> list = new List<int>();
            return GetPostOrderList(list, root);
        }

        private List<int> GetPostOrderList(List<int> list, BinaryTreeNode root)
        {

            if (root == null)
                return null;

            GetPostOrderList(list, root.Left);
            GetPostOrderList(list, root.Right);

            list.Add(root.Value);

            return list;
        }

        public int GetMax()
        {
            List<int> list = InOrder(Root);
            int max = list[0];
            foreach (int e in list)
            {
                if (e > max)
                    max = e;
            }

            return max;
        }

        public List<int> BreadthFirst(BinaryTreeNode root)
        {
            if (root == null)
                throw new Exception("Tree is empty!");

            return GetBreadthFirst(root, new Queue<BinaryTreeNode>(), new List<int>());
        }

        private List<int> GetBreadthFirst(BinaryTreeNode root, Queue<BinaryTreeNode> q, List<int> result)
        {
            result.Add(root.Value);

            if (root.Left != null)
                q.Enqueue(root.Left);

            if(root.Right != null)
                q.Enqueue(root.Right);

            if (q.Count != 0)
                GetBreadthFirst(q.Dequeue(), q, result);

            return result;
        }
    }
}
