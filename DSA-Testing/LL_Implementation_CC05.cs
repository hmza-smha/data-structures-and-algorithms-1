using System;
using Xunit;
using data_structures_and_algorithms.linked_list;

namespace DSA_Testing
{
    public class LL_Implementation_CC05
    {
        [Fact]
        public void Init_An_Empty_LL()
        {
            SinglyLinkedList list = new SinglyLinkedList();

            list.Isnert("1st element");

            Assert.Equal("[1st element] -> NULL", list.ToString());
        }

        [Fact]
        public void Inert_To_LL()
        {
            SinglyLinkedList list = new SinglyLinkedList();

            list.Isnert("first");
            list.Isnert("second");

            Assert.Equal("[second] -> [first] -> NULL", list.ToString());
        }

        [Fact]
        public void Head_Point_To_1st_Element()
        {
            SinglyLinkedList list = new SinglyLinkedList();

            list.Isnert("first");
            list.Isnert("second"); // this should be the head

            Assert.Equal("[second]", list.ToString().Split(" ")[0]);
        }

        [Fact]
        public void Find_Element()
        {
            SinglyLinkedList list = new SinglyLinkedList();

            list.Isnert("first");
            list.Isnert("second");

            Assert.True(list.Includes("first"));
        }

        [Fact]
        public void Cannot_Find_Element()
        {
            SinglyLinkedList list = new SinglyLinkedList();

            list.Isnert("first");
            list.Isnert("second");

            Assert.False(list.Includes("hello world"));
        }
    }
}
