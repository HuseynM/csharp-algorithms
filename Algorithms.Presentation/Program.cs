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
            int[] array = { -5, -2, -6, 5 };
            Console.WriteLine(ConditionalStatements.FindAllGreatest(array));
            Console.ReadLine();
        }
    }
}
