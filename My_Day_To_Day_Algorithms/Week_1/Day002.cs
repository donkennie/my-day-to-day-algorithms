using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Day_To_Day_Algorithms.Week_1
{
    public class Day002 // Learning about Recursive function. It's a function that calls itself and continue to do so until evaluation is finished...
    {

      /* public static void Main(string[] args)
        {
            //var i = Factorial(3);
            //Console.WriteLine(i);
        }
      */

        public static int Factorial(int n)
        {
            if (n < 0)
            {
                return -1;
            }
            else if (n == 0)
            {
                return 1;
            }

            else
            {
                return n * Factorial(n - 1); // The decrement of n. Assume n = 3.
                                             // 3, 2, 1 *(n).  Then, resulted to. 3 * 3, 2 * 3, 1* 3.
            }


        }
    }
}
