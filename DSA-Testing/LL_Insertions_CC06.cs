using System;
using Xunit;
using data_structures_and_algorithms.linked_list_insertion;

namespace DSA_Testing
{
    public class LL_Insertions_CC06
    {
        [Fact]
        public void Append_Test()
        {
            LinkedListInsertion list = new LinkedListInsertion();
            list.Append("0");
            list.Append("1");
            list.Append("2");

            Assert.Equal("[0] -> [1] -> [2] -> NULL", list.ToString());
        }

        [Fact]
        public void Insert_Before_i()
        {
            LinkedListInsertion list = new LinkedListInsertion();
            list.Append("0");
            list.Append("1");
            list.Append("2");

            list.InsertBefore("1", "0.5");

            Assert.Equal("[0] -> [0.5] -> [1] -> [2] -> NULL", list.ToString());
        }

        [Fact]
        public void Insert_Before_First()
        {
            LinkedListInsertion list = new LinkedListInsertion();
            list.Append("0");
            list.Append("1");
            list.Append("2");

            list.InsertBefore("0", "-1");

            Assert.Equal("[-1] -> [0] -> [1] -> [2] -> NULL", list.ToString());
        }

        [Fact]
        public void Insert_After_i()
        {
            LinkedListInsertion list = new LinkedListInsertion();
            list.Append("0");
            list.Append("1");
            list.Append("2");

            list.InsertAfter("1", "1.5");

            Assert.Equal("[0] -> [1] -> [1.5] -> [2] -> NULL", list.ToString());
        }

        [Fact]
        public void Insert_After_Last()
        {
            LinkedListInsertion list = new LinkedListInsertion();
            list.Append("0");
            list.Append("1");
            list.Append("2");

            list.InsertAfter("2", "2.5");

            Assert.Equal("[0] -> [1] -> [2] -> [2.5] -> NULL", list.ToString());
        }
    }
}
