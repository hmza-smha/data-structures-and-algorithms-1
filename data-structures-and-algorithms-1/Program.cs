using System;
using data_structures_and_algorithms_1.sorting.quick;

namespace data_structures_and_algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Data Structures & Algorithms!");
            int[] list = new int[] { 8, 4, 23, 42, 16, 15 };
            QuickSort q = new QuickSort();

            list = q.Sort(list, 0, list.Length - 1);

            foreach (var e in list)
            {
                Console.Write(e + ", ");
            }

        }
    }
}
