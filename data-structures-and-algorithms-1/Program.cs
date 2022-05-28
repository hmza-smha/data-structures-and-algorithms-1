using System;
using System.Collections.Generic;
using data_structures_and_algorithms_1;
using data_structures_and_algorithms_1.binary_tree;
using data_structures_and_algorithms_1.sorting.merge;
using data_structures_and_algorithms_1.trees;

namespace data_structures_and_algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Data Structures & Algorithms!");
            int[] list = new int[] { 8, 4, 23, 42, 16, 15 };
            MergeSort.Sort(list);
        }
    }
}
