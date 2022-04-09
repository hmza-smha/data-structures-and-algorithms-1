using System;
using data_structures_and_algorithms_1.stack_queue_pseudo;
using Xunit;

namespace DSA_Testing
{
    public class PseudoQueue_CC11
    {
        [Fact]
        public void Enqueue_Test()
        {
            PseudoQueue q = new PseudoQueue();
            q.Enqueue(1);
            q.Enqueue(2);

            Assert.Equal(1, q.Peek());
        }

        [Fact]
        public void Dequeue_Test()
        {
            PseudoQueue q = new PseudoQueue();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Dequeue();

            Assert.Equal(2, q.Peek());
        }
    }
}
