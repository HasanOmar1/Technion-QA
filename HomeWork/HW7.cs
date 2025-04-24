using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class HW7
    {
        public static bool Brothers(int num1 , int num2)
        {
            if(num1 <= 0 || num2 <= 0) return false;

            string num1String = num1.ToString();
            string num2String = num2.ToString();

            return num1String[0] == num2String[0] && num1String[num1String.Length - 1] == num2String[num2String.Length -1];

        }

    }
}
