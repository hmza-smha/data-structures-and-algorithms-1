using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_and_algorithms.array_binary_search
{
    class BinarySearch {
        int BiSearch(double[] arr, double key)
        {
            int lowerBound = 0;
            int upperBound = arr.Length - 1;
            int midPoint;

            while (upperBound >= lowerBound)
            {
                midPoint = lowerBound + (upperBound - lowerBound) / 2;

                if (arr[midPoint] < key)
                    lowerBound = midPoint + 1;

                if (arr[midPoint] > key)
                    upperBound = midPoint - 1;

                if (arr[midPoint] == key)
                    return midPoint;
            }

            return -1;
        }

        int BiSearch(double[] A, int lowerBound, int upperBound, double x)
        {
            if (lowerBound > upperBound)
                return -1;

            int mid = (lowerBound + upperBound) / 2;

            if (x == A[mid])
                return mid;

            else if (x < A[mid])
                return BiSearch(A, lowerBound, mid - 1, x);

            else
                return BiSearch(A, mid + 1, upperBound, x);
        }
    }
}
