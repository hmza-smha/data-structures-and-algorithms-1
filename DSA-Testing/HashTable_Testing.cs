using data_structures_and_algorithms_1.HashTable;
using System.Collections.Generic;
using Xunit;

namespace DSA_Testing
{
    public class HashTable_Testing
    {
        [Fact]
        public void Test_key_value()
        {
            HashTable table = new HashTable(10);
            table.Set(1, "10");

            Assert.Equal("10", table.Get(1));
        }

        [Fact]
        public void Test_key_does_not_exist()
        {
            HashTable table = new HashTable(10);

            Assert.Null(table.Get(1));
        }

        [Fact]
        public void Test_keys()
        {
            HashTable table = new HashTable(10);
            table.Set(1, "1");
            table.Set(2, "1");
            table.Set(3, "1");

            List<int> keys = new List<int>();
            keys.Add(1);
            keys.Add(2);
            keys.Add(3);

            Assert.Equal(keys, table.Keys());
        }

        [Fact]
        public void Test_Collision()
        {
            HashTable table = new HashTable(10);
            table.Set(1, "1");
            table.Set(11, "11");

            Assert.Equal("1", table.Get(1));
            Assert.Equal("11", table.Get(11));
        }

        [Fact]
        public void Test_Hash()
        {
            HashTable table = new HashTable(10);
            int key = 12354;

            Assert.True(table.Hash(key) < 10 && table.Hash(key) > 0);
        }
    }
}
