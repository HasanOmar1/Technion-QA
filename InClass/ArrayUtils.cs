using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InClass
{
    public class ArrayUtils
    {
        
        // if array is empty -  return empty array
        // if array is null  - return null
        public int[] GetEvenItemsInIntArray(int[] arr)
        {


            if (arr == null)
                return null;


            if ( arr.Length == 0)
                return new int[] { };

            int countEvens = 0;
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] % 2 == 0)
                    countEvens++;

            int[] evenArr = new int[countEvens];

            if (evenArr.Length == 0)
                return new int[] {} ;

            int index = 0;
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] % 2 == 0)
                    evenArr[index++] = arr[i];

            return evenArr;


        }
    }
}
