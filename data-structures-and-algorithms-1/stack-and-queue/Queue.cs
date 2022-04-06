using System;
using data_structures_and_algorithms;

namespace data_structures_and_algorithms_1.stack_and_queue
{
    public class Queue
    {
        Node Front;
        Node Rear;

        public void Enqeue(string value)
        {
            Node newNode = new Node(value);

            if (Rear == null && Front == null)
            {
                Front = Rear = newNode;
            }
            else
            {
                Rear.Next = newNode;
                Rear = newNode;
            }
        }

        public void Dequeue()
        {
            if (Front == null)
                throw new Exception("The Queue is empty!");

            Front = Front.Next;
        }

        public string Peek()
        {
            if (Rear == null)
                throw new Exception("The Queue is empty!");

            return Front.Value;
        }

        public bool IsEmpty()
        {
            return Front == null;
        }

        public override string ToString()
        {
            string result = "";

            if (Front == null)
                return "The List is Empty!";

            else
            {
                Node cur = Front;
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
