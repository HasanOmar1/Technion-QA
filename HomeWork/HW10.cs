using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class HW10
    {

        public static bool IsPrime(int num)
        {
            if (num < 2) return false;
            if (num == 2) return true;
            for (int i = 2; i < num; i++)
                if (num % i == 0) return false;

            return true;
        }

     
        public static bool ChkIfArrIsPrime(int[] arr)
        {
            if (arr == null || arr.Length == 0) return false;

            int primeCounter = 0;
            int notPrimeCounter = 0;
            for (int i = 0; i < arr.Length; i++)
                if (IsPrime(arr[i]))
                    primeCounter++;
                else
                    notPrimeCounter++;
            

            return primeCounter > notPrimeCounter;

        }
    }
}
