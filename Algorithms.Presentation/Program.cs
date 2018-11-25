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
            char[] arr1 = new char[5] { 'a', 'b', 'c', 'd', 'e' };
            char[] arr2 = new char[5] { 'c', 'b', 'c', 'd', 'e' };

            Console.WriteLine(Arrays.CheckLexicographicalOrder(arr1,arr2));

            Console.ReadLine();
        }
    }
}
