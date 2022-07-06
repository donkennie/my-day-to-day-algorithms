using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Day_To_Day_Algorithms.Week_1
{
    public class Day001 // Understanding how Big O notation works...                           
    {

        public static void Main(string[] args)
        {
            var i = PairSumSequence(3);
            Console.WriteLine(i);
        }


        public static int Sum(int n) //The runtime for this Sum() function is O(n)
        {
            if (n <= 0) //O(n)
            {
                return 0; // O(1)
            }

            return n + Sum(n - 1); // O(n)
        }


        public static int PairSumSequence(int n)  //The runtime for this PairSumSequence() function is O(n)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                  sum = sum + PairSum(i, i + 1);  //Solving the problem of Square root of a number

                //when i = 0,   1,    1 + pairsum(1)
                // when i = 1,  1,   2 + pairsum(3)
                // when i = 2,  4,   3 + pairsum(5)
                 //when i = 3,  9,   2 + pairsum(7)
            }
            return sum;
        }

        public static int PairSum(int a, int b)
        {
            return a + b;
        }
    }
}
