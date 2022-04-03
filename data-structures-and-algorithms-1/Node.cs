using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_and_algorithms
{
    public class Node
    {
        public string Value;
        public Node Next;

        public Node(string value)
        {
            this.Value = value;
            this.Next = null;
        }
    }
}
