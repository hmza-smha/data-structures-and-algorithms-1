using System;
using Xunit;
using data_structures_and_algorithms.linked_list_kth;

namespace DSA_Testing
{
    public class kthFromEnd_CC07
    {
        [Fact]
        public void k_Greater_Than_Length()
        {
            LinkedList_kth list = new LinkedList_kth();
            list.Append("0");
            list.Append("1");
            list.Append("2");

            Assert.Equal("Exception", list.kthFromEnd(10));
        }

        [Fact]
        public void k_Same_as_Length()
        {
            LinkedList_kth list = new LinkedList_kth();
            list.Append("0");
            list.Append("1");
            list.Append("2");

            Assert.Equal("Exception", list.kthFromEnd(3));
        }
        
        [Fact]
        public void k_isnot_Positive()
        {
            LinkedList_kth list = new LinkedList_kth();
            list.Append("0");
            list.Append("1");
            list.Append("2");

            Assert.Equal("Exception", list.kthFromEnd(-3));
        }

        [Fact]
        public void k_Somewhere()
        {
            LinkedList_kth list = new LinkedList_kth();
            list.Append("0");
            list.Append("1");
            list.Append("2");
            list.Append("3");

            Assert.Equal("2", list.kthFromEnd(1));
        }
    }
}
