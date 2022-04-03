using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_and_algorithms.linked_list
{
    public class SinglyLinkedList
    {
        Node Head;

        public void Isnert(string value)
        {
            Node newNode = new Node(value);

            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                newNode.Next = Head;
                Head = newNode;
            }
        }

        public string ToString()
        {
            string result = "";

            if (Head == null)
            {
                return "The List is Empty!";
            }
            else
            {
                Node cur = Head;
                while (cur != null)
                {
                    result += "[" + cur.Value + "] -> ";
                    cur = cur.Next;
                }
            }

            result += "NULL";

            return result;
        }

        public bool Includes(string value)
        {
            Node cur = Head;
            while (cur != null)
            {
                if (cur.Value == value)
                    return true;
                cur = cur.Next;
            }

            return false;
        }
    }
}
