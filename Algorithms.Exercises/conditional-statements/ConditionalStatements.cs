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

        public static int FindGreatest(int a, int b, int c)
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

        public static int FindGreatest(int[] a)
        {
            /*
             * Write a program that finds the greatest of given array.
             */

            int _val = int.MinValue;
            for (int i = 0; i < a.Length; i++)
            {
                if (_val < i)
                    _val = a[i];
            }

            return _val;
        }

    }
}
