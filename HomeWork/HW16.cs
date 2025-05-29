using System;

namespace HomeWork
{
    public class HW16
    {

        public static int[] BuildK(int[] a, int k)
        {
            int arrLength = k > 0 ? a.Length * k : a.Length;
            int[] arr = new int[arrLength];
            int count = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (k < 1)
                    arr[count++] = a[i];
                else
                    for (int j = 0; j < k; j++)
                        arr[count++] = a[i];
            }

            return arr;
        }

        public static int IsCopyK(int[] arr, int[] brr)
        {
            int k = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < brr.Length; j++)
                {
                    if (arr[i] == brr[j])
                        k++;
                    else
                        break;

                }
                break;

            }

            int[] a = BuildK(arr, k);
            bool isSame = true;
            if (a.Length == brr.Length)
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] != brr[i])
                        isSame = false;
                }
            else isSame = false;

            if (isSame) return k;


            return 0;
        }
    }
}
