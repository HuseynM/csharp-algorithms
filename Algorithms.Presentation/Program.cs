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
            int[] arr = new int[5] { 1, 2, 3, 4,5 };
            int[] arr2 = new int[4] { 1, 2, 3, 4 };

            bool result = Arrays.CompareArrays(arr, arr2);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
