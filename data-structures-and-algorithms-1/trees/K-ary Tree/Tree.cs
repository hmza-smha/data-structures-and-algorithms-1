using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_and_algorithms_1.trees
{
    public class Tree 
    {
        public TreeNode Root;

        /// <summary>
        /// Traverse the Tree using Breadth-First-Search algorithm.
        /// </summary>
        /// <returns>
        /// List of TreeNode
        /// </returns>
        public List<TreeNode> BFS()
        {
            TreeNode root = Root;
            Queue<TreeNode> q = new Queue<TreeNode>();
            List<TreeNode> result = new List<TreeNode>();

            while (root != null)
            {
                result.Add(root);

                if (root.Children.Count > 0)
                {
                    foreach (TreeNode child in root.Children)
                    {
                        q.Enqueue(child);
                    }
                }

                if (q.Count > 0)
                    root = q.Dequeue();
                else
                    root = null;
            }

            return result;
        }

        /// <summary>
        /// Get a 'NEW' FizzBuzz tree.
        /// </summary>
        /// <returns>
        /// Tree
        /// </returns>
        public Tree FizzBuzz()
        {
            Tree tree = new Tree();
            tree.Root = GetFizzBuzzRoot();
            return tree;
        }

        /// <summary>
        /// Get a root for FizzBuzz tree.
        /// </summary>
        /// <returns>
        /// TreeNode
        /// </returns>
        private TreeNode GetFizzBuzzRoot()
        {
            // The 'root' and 'Q' are used to traverse the original tree.
            TreeNode root = Root;
            Queue<TreeNode> Q = new Queue<TreeNode>();

            // The 'fizzbuzzRoot' will be the root for the new Tree.
            // The 'fizzbuzzQ' used to build the new tree (traking each node, to determine its children).
            TreeNode fizzbuzzRoot;
            Queue<TreeNode> fizzbuzzQ = new Queue<TreeNode>();

            // Determine the value of Fizzbuzz Tree's root.
            int rootValue = Convert.ToInt32(root.Value);

            if (rootValue % 3 == 0 && rootValue % 5 == 0)
                fizzbuzzRoot = new TreeNode("FizzBuzz");
            else if (rootValue % 3 == 0)
                fizzbuzzRoot = new TreeNode("Fizz");
            else if (rootValue % 5 == 0)
                fizzbuzzRoot = new TreeNode("Buzz");
            else
                fizzbuzzRoot = new TreeNode(Root.Value);

            // The 'temp' node used to track childern in the FizzBuzz tree.
            TreeNode temp = fizzbuzzRoot;

            // Traverse the original tree using BFS, and build the fizzbuzz tree at same time.
            while (root != null)
            {
                if (root.Children.Count > 0)
                {
                    foreach (TreeNode child in root.Children)
                    {
                        Q.Enqueue(child);

                        int childValue = Convert.ToInt32(child.Value);

                        if (childValue % 3 == 0 && childValue % 5 == 0)
                            temp.Children.Add(new TreeNode("FizzBuzz"));
                        else if (childValue % 3 == 0)
                            temp.Children.Add(new TreeNode("Fizz"));
                        else if (childValue % 5 == 0)
                            temp.Children.Add(new TreeNode("Buzz"));
                        else
                            temp.Children.Add(new TreeNode(child.Value));

                        fizzbuzzQ.Enqueue(temp);
                    }
                }

                if (Q.Count > 0)
                {
                    root = Q.Dequeue();
                    temp = fizzbuzzQ.Dequeue();
                }
                else
                {
                    root = null;
                }
                    
            }

            return fizzbuzzRoot;
        }
    }
}
