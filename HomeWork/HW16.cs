using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class HW16
    {

        public static int[] buildK(int[] a , int k)
        {
            int arrLength = k > 0 ? a.Length * k : a.Length;
            int[] arr = new int[arrLength];
            int count = 0;

            for (int i = 0;  i < a.Length;  i++)
            {
                if(k == 0)
                    arr[count++] = a[i];
                else
                    for (int j = 0; j < k; j++)
                        arr[count++] = a[i];
            }

            return arr;
        }
    }
}
