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
            int[] arr = new int[20];

            foreach (var a in Arrays.MultipleByFiveArray(arr))
            {
                Console.WriteLine(a);
            }
            Console.ReadLine();
        }
    }
}
