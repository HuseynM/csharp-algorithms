using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Exercises.arrays
{
    public static class Arrays
    {
        public static void PrintToN(int n) // Exercise 1
        {
            /*
                Write a program that prints on the console the numbers from 1 to N.
                The number N should be read from the standard input.
             */

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void PrintNotDivisible(int n, int a, int b) // Exercise 1
        {
            /*
                Write a program that prints on the console the numbers from 1 to N,
                which are not divisible by a and b simultaneously. The number N
                should be read from the standard input.
             */

            for (int i = 0; i < n; i++)
            {
                if (n % a != 0 && n % b != 0)
                    Console.WriteLine(i);
            }
        }
    }
}
