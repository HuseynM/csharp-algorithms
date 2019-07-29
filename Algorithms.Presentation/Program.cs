using Algorithms.Exercises.data_structures;
using System;
using System.Collections.Generic;

namespace Algorithms.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = DataStructure.FindLongestSubsequence(new List<int> { 1, 1, 1, 1, 2, 3, 5, 6 });
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
