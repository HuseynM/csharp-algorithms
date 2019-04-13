using Algorithms.Exercises.arrays;
using Algorithms.Exercises.conditional_statements;
using Algorithms.Exercises.operators_and_expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };

            foreach (var item in Arrays.FindMostFrequentlyOccuredElement(arr))
            {
                Console.WriteLine(item);
            } 

            Console.ReadLine();
        }
    }
}
