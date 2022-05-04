using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_and_algorithms_1.trees
{
    public class TreeNode
    {
        public string Value;
        public List<TreeNode> Children;

        public TreeNode(string value)
        {
            Value = value;
            Children = new List<TreeNode>();
        }
    }
}
