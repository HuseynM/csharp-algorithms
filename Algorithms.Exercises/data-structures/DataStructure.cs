using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Exercises.data_structures
{
    public class DataStructure
    {
        public static Stack<int> StackReverse(Stack<int> list)
        {
            /*
             Write a program, which reads from the console N integers and prints
                them in reversed order. Use the Stack<int> class.
             */
            Stack<int> innerList = new Stack<int>();
            for (int i = 0; i <list.Count; i++)
            {
                innerList.Push(list.ElementAt(i));
            }

            return innerList;
        }

        public static List<int> FindLongestSubsequence(List<int> list)
        {
            /*
             Write a method that finds the longest subsequence of equal numbers
                in a given List<int> and returns the result as new List<int>. Write a
                program to test whether the method works correctly.
             */
            int tempCount = 1, count = 1, number = 0;
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] == list[i + 1]) tempCount++;
                else tempCount = 1;

                if (tempCount > count)
                {
                    count = tempCount;
                    number = list[i];
                }
            }

            List<int> localList = new List<int>();
            for (int i = 0; i < count; i++)
            {
                localList.Add(number);
            }

            return localList;

        }
    }
}
