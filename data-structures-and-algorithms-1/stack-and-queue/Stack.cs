using System;
using data_structures_and_algorithms;
namespace data_structures_and_algorithms_1.stack_and_queue
{
    public class Stack
    {
        Node Top;
        public void Push(string value)
        {
            Node newNode = new Node(value);
            newNode.Next = Top;
            Top = newNode;
        }

        public void Pop()
        {
            if (Top == null)
                throw new Exception("Empty Stack!");

            Top = Top.Next;
        }

        public string Peek()
        {
            if (Top == null)
                throw new Exception("Empty Stack!");

            return Top.Value;
        }

        public bool IsEmpty()
        {
            return Top == null;
        }

        public override string ToString()
        {
            string result = "";

            if (Top == null)
                return "The List is Empty!";
            
            else
            {
                Node cur = Top;
                while (cur != null)
                {
                    result += "[" + cur.Value + "] -> ";
                    cur = cur.Next;
                }
            }

            result += "NULL";

            return result;
        }
    }
}
