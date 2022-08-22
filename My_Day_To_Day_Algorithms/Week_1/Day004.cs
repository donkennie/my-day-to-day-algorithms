using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Day_To_Day_Algorithms.Week_1
{
    public class Day004
    {
        //How does an ARRAY work?
        public static void Main(string[] args)
        {


            int[] y = { 1, 3, 0, 0 };

            var watch = new Stopwatch();

            watch.Start();

            // int o = fun1(3);
            int o = fun3(7);

            watch.Stop();


            Console.WriteLine(o);

            Console.WriteLine($"Time taken:{watch.Elapsed:g}");
        }



        public static int fun1(int n)  // This returns the size of a given number
        {
            int m = 0;

            for (int i = 0; i < n; i++)
            { 

                m += 1;
            }

            return m;
        }


        public static int fun2(int n) //Just like you're squaring the given number
        {
            int i, j, m = 0;

            for (i = 0; i < n; i++)   //when j = 7, i = 1. when j = 7(again), i = 2. when j = 7(again), i = 3. 
            {
                for (j = 0; j < n; j++) //This would count n(the given number) times of the number given. 
                {
                    m += 1; //m increases as it adds. M is the count until it reaches 49. 
                }
            }

            return m;
        }


       public static int fun3(int n) //Just like you're multiplying the given number by two
        {
            int i, j, m = 0;

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < i; j++)
                {
                    m += 1;
                }
            }

            return m;
        }




    }
}
