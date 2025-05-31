namespace HomeWork
{
    public class HW16
    {

        public static int[] BuildK(int[] a, int k)
        {
            if (a == null) return null;
            if (a.Length == 0 || k <= 0) return new int[] { };

            int[] arr = new int[a.Length * k];
            int count = 0;

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < k; j++)
                    arr[count++] = a[i];
            }

            return arr;
        }

        public static int IsCopyK(int[] arr, int[] brr)
        {
            if (arr == null) return 0;
            if (brr == null) return 0;

            int k = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < brr.Length; j++)
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
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] != brr[i])
                        isSame = false;
                }
            }
            else isSame = false;

            if (isSame) return k;


            return 0;
        }
    }
}
