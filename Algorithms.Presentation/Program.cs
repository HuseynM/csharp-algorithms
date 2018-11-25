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
            foreach (var item in Arrays.FindConsequtiveEqualElements(new int[] { 1, 1, 2, 2, 3, 3, 3, 3 }))
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
