using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using data_structures_and_algorithms.linked_list_insertion;

namespace data_structures_and_algorithms.linked_list_kth
{
    public class LinkedList_kth : LinkedListInsertion
    {
        public string kthFromEnd(int k)
        {
            if (k < 0)
                return "Exception";

            if (head == null)
                return "List is Empty!";

            List<string> list = new List<string>();

            Node cur = head;
            while(cur != null)
            {
                list.Add(cur.Value);
                cur = cur.Next;
            }

            if(k > list.Count - 1)
                return "Exception";
            else
                return list[list.Count - k - 1];
        }
    }
}
