﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Exercises.arrays
{
    public static class Arrays
    {
        public static int[] FindTwoLargestElements(int[] arr)
        {
            int a = int.MinValue, b = int.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > a)
                {
                    b = a;
                    a = arr[i];
                }
                else if (arr[i] > b)
                {
                    b = arr[i];
                }
            }

            return new int[] { a, b };
        }
        public static int[] MultipleByFiveArray(int[] array) //Exercise 1
        {
            /*
             Write a program, which creates an array of 20 elements of type
             integer and initializes each of the elements with a value equals to the
             index of the element multiplied by 5. Print the elements to the console.
             */
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * 5;
            }

            return array;
        }

        public static bool CompareArrays(int[] arr1, int[] arr2) // Exercise 2
        {
            /*
             * Write a program, which reads two arrays from the console and checks
                whether they are equal (two arrays are equal when they are of equal
                length and all of their elements, which have the same index, are equal).
             */

            if (arr1.Length != arr2.Length)
                return false;

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                    return false;
            }
            return true;
        }

        public static string CheckLexicographicalOrder(char[] arr1, char[] arr2) //Exercise 3
        {
            /*
             Write a program, which compares two arrays of type char
                lexicographically (character by character) and checks, which one is first
                in the lexicographical order.
             */
            string result = string.Empty;
            if (arr1.Length != arr2.Length) return "Lenghts are different";
            else
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i] < arr2[i])
                    {
                        result = "First array lexicographical";
                        return result;
                    }
                    else if (arr1[i] > arr2[i])
                    {
                        result = "Second array lexicographical";
                        return result;
                    }
                    else
                    {
                        result = "Arrays are equal";
                        return result;
                    }
                }
                return result;
            }

        }

        public static int[] FindConsequtiveEqualElements(int[] arr) //Exercise 4
        {
            /*
             Write a program, which finds the maximal sequence of consecutive
                equal elements in an array. E.g.: {1, 1, 2, 3, 2, 2, 2, 1}  {2, 2, 2}.
             */

            int tempCount = 1, count = 1, number = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1]) tempCount++;
                else tempCount = 1;

                if (tempCount > count)
                {
                    count = tempCount;
                    number = arr[i];
                }
            }

            int[] localArr = new int[count];
            for (int i = 0; i < count; i++)
            {
                localArr[i] = number;
            }

            return localArr;
        }

        public static int[] FindConsequtiveIncreasingElements(int[] arr) //Exercise 5
        {
            /*
             * Write a program, which finds the maximal sequence of consecutively
                placed increasing integers. Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.

            int[] arr = new int[5] { 1, 5, 6, 7, 8 };
             */

            /*
               int[] arr = new int[5] { 1, 5, 6, 7, 8 };
            int count = 1;
            int start = 0;
            int bestStart = 0;
            int maxCount = 1;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] - 1 != arr[i - 1])
                {
                    {
                        count = 0;
                        start = i;
                    }
                }
                count++;
                if (count > maxCount)
                {
                    bestStart = start;
                    maxCount = count;
                }
            }

            int[] result = new int[maxCount];

            for (int i = 0; i < maxCount; i++)
            {
                result[i] = arr[i + bestStart];
                Console.WriteLine(result[i]);
            }
             */

            int tempCount = 1, count = 1, number = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] + 1 == arr[i + 1]) tempCount++;
                else tempCount = 1;

                if (tempCount > count)
                {
                    count = tempCount;
                    number = arr[i];
                }
            }

            int[] localArr = new int[count];
            for (int i = 0; i < count; i++)
            {
                localArr[i] = (number + 1) - (count - 1) + i;
            }

            return localArr;

        }

        public static int[] FindMaxSequenceIncreasingElements(int[] arr) //Exercise 6
        {
            /*
             Write a program, which finds the maximal sequence of increasing
                elements in an array arr[n]. It is not necessary the elements to be
                consecutively placed. E.g.: {9, 6, 2, 7, 4, 7, 6, 5, 8, 4}  {2, 4, 6, 8}.
             */

            return arr;
        }

        public static int[] Sort(int[] arr) //Exercise 8 
        {
            /*
             Sorting an array means to arrange its elements in an increasing (or
                decreasing) order. Write a program, which sorts an array using the
                algorithm "selection sort".
             */

            int n = arr.Length;
            for (int x = 0; x < n; x++)
            {
                int min_index = x;
                for (int y = x; y < n; y++)
                {
                    if (arr[min_index] > arr[y])
                    {
                        min_index = y;
                    }
                }
                int temp = arr[x];
                arr[x] = arr[min_index];
                arr[min_index] = temp;
            }

            return arr;
        }

        public static int[] FindMostFrequentlyOccuredElement(int[] arr) //Exercise 10
        {
            /*
             Write a program, which finds the most frequently occurring element in
                an array. Example: {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times).

             */
            Array.Sort(arr); // {1,1,1,2,2,3,3,4,4,4,4,4,9}
            int tempCount = 1, count = 1, number = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1]) tempCount++;
                else tempCount = 1;

                if (tempCount > count)
                {
                    count = tempCount;
                    number = arr[i];
                }
            }

            arr = new int[count];
            for (int i = 0; i < count; i++)
            {
                arr[i] = number;
            }

            return arr;
        }

        public static int[] SumOfCertainS(int[] arr, int s = 11) // Exercise 11
        {
            /*
             * Write a program to find a sequence of neighbor numbers in an array,
                which has a sum of certain number S. Example: {4, 3, 1, 4, 2, 5, 8},
                S=11  {4, 2, 5}.
             */

            return new int[] { };
        }
    }
}
