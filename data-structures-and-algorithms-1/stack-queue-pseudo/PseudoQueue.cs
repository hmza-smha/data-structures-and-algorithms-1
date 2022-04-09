using System;
using System.Collections;
namespace data_structures_and_algorithms_1.stack_queue_pseudo
{
    public class PseudoQueue
    {
		public Stack s1 = new Stack();
		public Stack s2 = new Stack();

		public void Enqueue(int x)
		{
			// Move all elements from s1 to s2
			while (s1.Count > 0)
				s2.Push(s1.Pop());

			// Push item into s1
			s1.Push(x);

			// Push everything back to s1
			while (s2.Count > 0)
				s1.Push(s2.Pop());
		}

		public void Dequeue()
		{
			if (s1.Count == 0)
				Console.WriteLine("Q is Empty");

			s1.Pop();
		}

		public Object Peek()
		{
			return s1.Peek();
		}
	}
}
