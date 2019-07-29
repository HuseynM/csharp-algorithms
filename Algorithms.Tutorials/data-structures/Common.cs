using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Tutorials.data_structures
{
    public class Common
    {
        public static List<int> GetPrimes(int start, int end)
        {
            List<int> primesList = new List<int>();
            for (int num = start; num <= end; num++)
            {
                bool prime = true;
                double numSqrt = Math.Sqrt(num);
                for (int div = 2; div <= numSqrt; div++)
                {
                    if (num % div == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                if (prime)
                    primesList.Add(num);
            }

            return primesList;
        }
    }
}
