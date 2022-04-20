using System;
using Xunit;
using data_structures_and_algorithms_1.stack_queue_brackets;

namespace DSA_Testing
{
    public class StackQueueBracket
    {
        [Theory]
        [InlineData(true, "{}")]
        [InlineData(true, "{}(){}")]
        [InlineData(true, "()[[Extra Characters]]")]
        [InlineData(true, "(){}[[]]")]
        [InlineData(true, "{}{Code}[Fellows](())")]
        [InlineData(false, "[({}]")]
        [InlineData(false, "(](")]
        [InlineData(false, "{(})")]
        public void Test1(bool expected, string input)
        {
            Assert.Equal(expected, StackQueueBrackets.IsBalanced(input));
        }
    }
}
