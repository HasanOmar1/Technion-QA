using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class HW6
    {
        public static double CalcAverageOfIntArr(int[] arr)
        {
            if (arr == null || arr.Length == 0) return double.MinValue;
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
                sum += arr[i];

            return (double) sum / arr.Length;

        }

    }
}
