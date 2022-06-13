using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using data_structures_and_algorithms_1.HashTable.hashmap_repeated_word;
using Xunit;

namespace DSA_Testing
{
    public class RepeatedWord_CC31
    {
        [Theory]
        [InlineData("a", "Once upon a time, there was a brave princess who...")]
        [InlineData("it", "It was the best of times, it was the worst of times")]
        [InlineData("summer", "It was a queer, sultry summer, the summer they electrocuted the Rosenbergs, ")]
        public void Repeated_word_test(string expected, string input)
        {
            HashTable table = new HashTable();
            Assert.Equal(expected, table.GetRepeatedWord(input));
        }
    }
}
