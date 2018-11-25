using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Exercises.arrays
{
    public static class Arrays
    {
        public static int[] MultipleByFiveArray(int[] array) //Exercise 1
        {
            /*
             Write a program, which creates an array of 20 elements of type
             integer and initializes each of the elements with a value equals to the
             index of the element multiplied by 5. Print the elements to the console.
             */
            array = new int[20];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * 5;
            }

            return array;
        }
    }
}
