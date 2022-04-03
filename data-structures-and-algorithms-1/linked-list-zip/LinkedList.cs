using System;
using data_structures_and_algorithms;

namespace data_structures_and_algorithms_1.linked_list_zip
{
    public class LinkedList
    {
        public Node Head;

        public void Append(string new_data)
        {
            Node new_node = new Node(new_data);

            if (Head == null)
            {
                Head = new Node(new_data);
                return;
            }

            new_node.Next = null;

            Node last = Head;
            while (last.Next != null)
                last = last.Next;

            last.Next = new_node;
        }

        public static LinkedList Zip(LinkedList list1, LinkedList list2)
        {
            LinkedList zipped = new LinkedList();

            Node cur1 = list1.Head;
            Node cur2 = list2.Head;

            // store which value will be added to zipped LL
            string nextValue;

            bool switsh = false;

            // merge the LLs, simillar to 'Merge Sort' in 'Merginig'
            while (cur1 != null && cur2 != null)
            {
                if (switsh)
                {
                    nextValue = cur2.Value;
                    cur2 = cur2.Next;
                    switsh = false;
                }
                else
                {
                    nextValue = cur1.Value;
                    cur1 = cur1.Next;
                    switsh = true;
                }

                zipped.Append(nextValue);
            }

            if (cur1 != null)
            {
                while (cur1 != null)
                {
                    zipped.Append(cur1.Value);
                    cur1 = cur1.Next;
                }
            }

            if (cur2 != null)
            {
                while (cur2 != null)
                {
                    zipped.Append(cur2.Value);
                    cur2 = cur2.Next;
                }
            }

            return zipped;
        }


        public string ToString()
        {
            if (Head == null)
                return "LinkedList is Empty";
            else
            {
                string result = "";
                Node cur = Head;
                while (cur != null)
                {
                    result += "[" + cur.Value + "] -> ";
                    cur = cur.Next;
                }
                return result + "NULL";
            }
        }


    }
}
