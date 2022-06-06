using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_and_algorithms_1.HashTable
{
    public class Node
    {
        public int Key;
        public string Value;
        public Node Next;

        public Node(int key, string value)
        {
            Key = key;
            Value = value;
        }
    }
}
