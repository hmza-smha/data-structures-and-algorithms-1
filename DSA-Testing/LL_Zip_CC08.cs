using System;
using Xunit;
using data_structures_and_algorithms_1.linked_list_zip;
namespace DSA_Testing
{
    public class LL_Zip_CC08
    {
        [Fact]
        public void Zip_Same_Length()
        {
            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();

            list1.Append("1");
            list1.Append("2");
            list1.Append("3");

            list2.Append("4");
            list2.Append("5");
            list2.Append("6");

            LinkedList zipped = LinkedList.Zip(list1, list2);

            Assert.Equal("[1] -> [4] -> [2] -> [5] -> [3] -> [6] -> NULL", zipped.ToString());
        }

        [Fact]
        public void Zip_Different_Length()
        {
            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();

            list1.Append("1");
            list1.Append("2");
            list1.Append("3");

            list2.Append("4");
            list2.Append("5");
            list2.Append("6");
            list2.Append("7");
            list2.Append("8");

            LinkedList zipped = LinkedList.Zip(list1, list2);

            Assert.Equal("[1] -> [4] -> [2] -> [5] -> [3] -> [6] -> [7] -> [8] -> NULL", zipped.ToString());
        }
    }
}
