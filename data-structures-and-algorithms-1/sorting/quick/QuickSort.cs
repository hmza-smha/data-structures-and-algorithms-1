using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_and_algorithms_1.sorting.quick
{
    public class QuickSort
    {
        public int[] Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int position = Partition(arr, left, right);

                Sort(arr, left, position - 1);
                Sort(arr, position + 1, right);
            }

            return arr;
        }

        public int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];
            int low = left - 1;

            for (int i = left; i < right; i++)
            {
                if (arr[i] <= pivot)
                {
                    low++;
                    Swap(arr, i, low);
                }
            }

            Swap(arr, right, low + 1);

            return low + 1;
        }

        public void Swap(int[] arr, int i, int low)
        {
            int temp = arr[i];
            arr[i] = arr[low];
            arr[low] = temp;
        }
    }
}
