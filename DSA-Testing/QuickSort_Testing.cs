using Xunit;
using data_structures_and_algorithms_1.sorting.quick;

namespace DSA_Testing
{
    public class QuickSort_Testing
    {
        [Fact]
        public void Test1()
        {
            int[] list = new int[] { 8, 4, 23, 42, 16, 15 };
            QuickSort q = new QuickSort();

            int[] sorted = new int[] { 4, 8, 15, 16, 23, 42 };

            Assert.Equal(sorted, q.Sort(list, 0, list.Length - 1));
        }

        [Fact]
        public void Test2()
        {
            int[] list = new int[] { 1, 5, 4, 3, 2 };
            QuickSort q = new QuickSort();

            int[] sorted = new int[] { 1,2,3,4,5 };

            Assert.Equal(sorted, q.Sort(list, 0, list.Length - 1));
        }

        [Fact]
        public void Test3()
        {
            int[] list = new int[] { 1, 2, 3, 4, 5 };
            QuickSort q = new QuickSort();

            int[] sorted = new int[] { 1, 2, 3, 4, 5 };

            Assert.Equal(sorted, q.Sort(list, 0, list.Length - 1));
        }

        [Fact]
        public void Test4()
        {
            int[] list = new int[] { 0,0,0,0,0 };
            QuickSort q = new QuickSort();

            int[] sorted = new int[] { 0, 0, 0, 0, 0 };

            Assert.Equal(sorted, q.Sort(list, 0, list.Length - 1));
        }
    }
}
