using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Exercises.conditional_statements
{
    public static class ConditionalStatements
    {
        public static int[] ExchangeValues(int a, int b)
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
        }

        public static int FindBiggest(int a, int b, int c)
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
    }
}
