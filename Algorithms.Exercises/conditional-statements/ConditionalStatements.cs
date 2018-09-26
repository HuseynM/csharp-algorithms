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

    }
}
