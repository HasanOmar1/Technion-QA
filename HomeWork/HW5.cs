using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class HW5
    {
        public bool IsValidCellNum(string str)
           
        {
            //if (str == null) return false;
            if (str == null || str.Length != 11  || str[3] != '-') return false;

            for (int i = 4; i < str.Length; i++)
                if (!Char.IsDigit(str[i]))  return false;
          
            string[] validPrefix = { "050"  , "051"  , "052" , "053" , "054" , "055" , "056" , "057" , "058" };
            string prefix = str.Substring(0, 3);
            if (!validPrefix.Contains(prefix)) return false;

            return true;




        }
    }
}
