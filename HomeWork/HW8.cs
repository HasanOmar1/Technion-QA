using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class HW8
    {

        // returns the max num in array of integers
        // if the arr is empty or the argument is null - return int.MinValue
        public static int GetMaxNumInIntArr(int[] arr)
        {
            if (arr == null || arr.Length == 0) return int.MinValue;

            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if(arr[i] > max)
                    max = arr[i];
            }

            return max;
        }
    }
}
