using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class HW11
    {

        public static bool IsSpecial(string str)
        {
            if(str == null || str.Length == 0) return false;

            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] < 'a' || str[i] > 'z') return false;

                bool isThere = false;

                for(int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j] && i != j)
                        isThere = true ;
                }
                if (isThere) return false;
            }


            return true;
        }
    }
}
