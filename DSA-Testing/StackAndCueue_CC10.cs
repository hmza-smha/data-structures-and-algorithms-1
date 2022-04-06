using System;
using Xunit;
using data_structures_and_algorithms_1.stack_and_queue;

namespace DSA_Testing
{
    public class StackAndCueue_CC10
    {
        [Theory]
        [InlineData("5", "5")]
        [InlineData("good", "good")]
        [InlineData("-1", "-1")]
        public void Pushing(string expected, string input)
        {
            Stack stack = new Stack();
            stack.Push(input);

            Assert.Equal(expected, stack.Peek());
        }

        [Fact]
        public void Pushing_Multiple_Values()
        {
            Stack stack = new Stack();
            stack.Push("0");
            stack.Push("1");
            stack.Push("Hi");

            Assert.Equal("[Hi] -> [1] -> [0] -> NULL", stack.ToString());
        }

        [Fact]
        public void Poping()
        {
            Stack stack = new Stack();
            stack.Push("0");
            stack.Push("1");
            stack.Push("Hi");

            stack.Pop();

            Assert.Equal("[1] -> [0] -> NULL", stack.ToString());
        }

        [Fact]
        public void Poping_Multiple()
        {
            Stack stack = new Stack();
            stack.Push("0");
            stack.Push("1");
            stack.Push("Hi");

            stack.Pop();
            stack.Pop();
            stack.Pop();

            Assert.True(stack.IsEmpty());
        }

        [Fact]
        public void Peek_Stack()
        {
            Stack stack = new Stack();
            stack.Push("0");
            stack.Push("1");
            stack.Push("Hi");

            Assert.Equal("Hi", stack.Peek());
        }

        [Fact]
        public void Init_Stack()
        {
            Stack stack = new Stack();
            Assert.True(stack.IsEmpty());
        }
        
        [Fact]
        public void Pop_Throw_Exceptions_Stack()
        {
            Stack stack = new Stack();
            Assert.Throws<Exception>(() => stack.Pop());
        }

        [Fact]
        public void Peek_Throw_Exceptions_Stack()
        {
            Stack stack = new Stack();
            Assert.Throws<Exception>(() => stack.Peek());
        }

        [Theory]
        [InlineData("5", "5")]
        [InlineData("good", "good")]
        [InlineData("-1", "-1")]
        public void Enqueue(string expected, string input)
        {
            Queue q = new Queue();
            q.Enqeue(input);
            Assert.Equal(expected, q.Peek());
        }

        [Fact]
        public void Enqueue_Multiple_Values()
        {
            Queue q = new Queue();
            q.Enqeue("0");
            q.Enqeue("1");
            q.Enqeue("2");
            Assert.Equal("[0] -> [1] -> [2] -> NULL", q.ToString());
        }

        [Fact]
        public void Denqueue()
        {
            Queue q = new Queue();
            q.Enqeue("0");
            q.Enqeue("1");
            q.Enqeue("2");

            q.Dequeue();
            Assert.Equal("[1] -> [2] -> NULL", q.ToString());
        }

        [Fact]
        public void Peek_Queue()
        {
            Queue q = new Queue();
            q.Enqeue("0");
            q.Enqeue("1");
            q.Enqeue("2");
            Assert.Equal("0", q.Peek());
        }

        [Fact]
        public void Empty_Queue()
        {
            Queue q = new Queue();
            q.Enqeue("0");
            q.Enqeue("1");
            q.Enqeue("2");

            q.Dequeue();
            q.Dequeue();
            q.Dequeue();

            Assert.True(q.IsEmpty());
        }

        [Fact]
        public void Init_Queue()
        {
            Queue q = new Queue();
            Assert.True(q.IsEmpty());
        }

        [Fact]
        public void Dequeue_Throw_Exceptions_Queue()
        {
            Queue q = new Queue();
            Assert.Throws<Exception>(() => q.Dequeue());
        }

        [Fact]
        public void Peek_Throw_Exceptions_Queue()
        {
            Queue q = new Queue();
            Assert.Throws<Exception>(() => q.Peek());
        }
    }
}
