using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_and_algorithms.revarse_array
{
    class Revarse
    {
        public double[] ReverseArray(double[] arr)
        {
            int counter = arr.Length;

            double[] revarse = new double[counter];

            for (int i = 0; i < arr.Length; i++)
            {
                revarse[i] = arr[--counter];
            }

            return revarse;
        }
    }
}
