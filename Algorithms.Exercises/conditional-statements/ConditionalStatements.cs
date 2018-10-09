using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Exercises.conditional_statements
{
    public static class ConditionalStatements
    {
        public static int[] ExchangeValues(int a, int b) // Exercise 1
        {
            /*
                Write an if-statement that takes two integer variables and exchanges
                their values if the first one is greater than the second one.
             */

            if (a > b)
            {
                a = a - b;
                b = a + b;
                a = b - a;
            }

            int[] result = { a, b };
            return result;
        } // Exercise 1 

        public static int FindGreatest(int a, int b, int c)  // Exercise 3
        {
            /*
             Write a program that finds the biggest of three integers, using nested
             if statements.
             */

            if (a > b && a > c)
                return a;
            else if (b > a && b > c)
                return b;
            else if (c > a && c > b)
                return c;
            else
                return 0;

        } 
        

        public static int FindGreatest(int[] a) // Exercise 7
        {
            /*
             * Write a program that finds the greatest of given array.
             */

            int max = int.MinValue;
            for (int i = 0; i < a.Length; i++)
            {
                if (max < i)
                    max = a[i];
            }

            return max;
        }

        public static int FindAllGreatestCount(int[] a)
        {
            /*
             * Write a program that finds all greatest numbers of given array.
             */

            int max = a[0];
            int count = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (max == a[i])
                    count += 1;
                else if (a[i] > max)
                {
                    max = a[i];
                    count = 1;
                }
            }

            return count;
        }



    }
}
