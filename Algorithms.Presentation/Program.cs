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
            foreach (var value in ConditionalStatements.ExchangeValues(5, 3))
            {
                Console.WriteLine(value);
            }
            Console.ReadLine();
        }
    }
}
