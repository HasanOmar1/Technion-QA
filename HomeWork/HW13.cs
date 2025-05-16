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
        // note: if the input arr is {0,1,2} ,  i.e. a == 0 , return null
        public string[] SolveQuadraticEquation(int[] coEfficients)
        {
           

            if (coEfficients.Length != 3 || coEfficients[0] == 0)
                return null;

            int a = coEfficients[0];
            int b = coEfficients[1];
            int c = coEfficients[2];

            string[] result = new string[3];
            double solution1 = 0;
            double solution2 = 0;
            string big;
            string small; 


            if ((b * b) - (4 * a * c) == 0)
            {
                solution1 = (-b + Math.Sqrt((b * b) - (4 * a * c))) / (2 * a);
                solution2 = (-b - Math.Sqrt((b * b) - (4 * a * c))) / (2 * a);

                big = solution1 > solution2 ? solution1.ToString() : solution2.ToString();
                small = solution1 < solution2 ? solution1.ToString() : solution2.ToString();

                if (small == big)
                    small = null;


                result = new string[] { "1", big, small };
            }
            else if ((b * b) - (4 * a * c) > 0)
            {
                solution1 = (-b + Math.Sqrt((b * b) - (4 * a * c))) / (2 * a);
                solution2 = (-b - Math.Sqrt((b * b) - (4 * a * c))) / (2 * a);

                big = solution1 > solution2 ? solution1.ToString() : solution2.ToString();
                small = solution1 < solution2 ? solution1.ToString() : solution2.ToString();

                result = new string[] { "2", big, small };

            }
            else
                result = new string[] { "0", null, null };

            return result;   
        }
    }
}
