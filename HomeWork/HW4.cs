using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class HW4
    {
        public static bool perfectNumber(int num)
        {
            if(num <= 0) return false;
            int sum = 0;
            int temp = num;
            while(temp != 0)
            {
                sum += temp % 10;
                temp /= 10;
            }

            return num % sum == 0 ;

        }
    }
}
