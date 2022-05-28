using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_and_algorithms_1.sorting.merge
{
    public class MergeSort
    {
        public static void Sort(List<int> arr)
        {
            int mid = arr.Count / 2;

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            for(int i = 0; i < mid; i++)
            {
                left.Add(arr[i]);
            }

            for (int i = mid; i < arr.Count; i++)
            {
                right.Add(arr[i]);
            }

            //Sort(left);
            //Sort(right);
            //Merge(left, right, arr);
        }

        public static void Merge(List<int> left, List<int> right, List<int> arr)
        {

        }
    }
}
