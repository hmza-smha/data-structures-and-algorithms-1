using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_and_algorithms.array_insert_shift
{
    class InsertShift
    {
        int[] insertShiftArray(int[] arr, int value)
        {

            int[] result = new int[arr.Length + 1];

            int midPoint = (int)result.Length / 2;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i < midPoint)
                    result[i] = arr[i];

                if (i == midPoint)
                    result[i] = value;

                if (i >= midPoint)
                    result[i + 1] = arr[i];
            }

            return result;
        }
    }
}
