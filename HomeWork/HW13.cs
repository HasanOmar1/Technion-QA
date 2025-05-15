using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class HW13
    {
        // ax^2  + bx + c = 0
        // x1,2 = (-b +- sqrt(b^2 - 4ac) ) / 2a
        // result[0] ==> how many solutions we get("0" / "1" / "2")
        // result[1] ==> The bigger solution ( as a string)
        // result[2] ==> The smaller solution (as a string)
        // int[] coEfficients = { a, b, c } of aX^2  + bX + c 
        // meaning: if the length of the input array is not 3  - return null
        //  note: if the input arr is {0,1,2} ,  i.e. a == 0 , return null
        public string[] SolveQuadraticEquation(int[] coEfficients)
        {
            if(coEfficients.Length != 3)
                return null;

            if(coEfficients[0] == 0)
                return null;

            string[] result = { "0", null, null };

            

            return result;   
        }
    }
}
