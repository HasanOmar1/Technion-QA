using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class HW12

    {
        // if the input string is "" return empty arr
        // if the input string is null -  return  null

        public string[] getSubArrByStartingCh(string s , char ch)
        {
            if (s == null) return null;

            if (s.Equals("")) return new string[] {};

            int count = 0;
            for (int i = 0; i < s.Length; i++)
                if (s[i] == ch)
                    count++;
                

            string[] subStrings = new string[count];
            int index = 0;
             for (int i = 0; i < s.Length; i++)
                if (s[i] == ch)
                    subStrings[index++] = s.Substring(i);

            return subStrings;
        }
    }
}
