using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Tutorials.data_structures
{
    public class CustomArrayList<T>
    {
        private T[] arr;
        private int count;

        public int Count
        {
            get
            {
                return count;
            }
        }

        private const int INITIAL_CAPACITY = 4;

        public CustomArrayList(int capacity = INITIAL_CAPACITY)
        {
            arr = new T[capacity];
            count = 0;
        }


        private void GrowIfArrIsFull()
        {
            if (count + 1 > arr.Length)
            {
                T[] extendedArr = new T[arr.Length * 2];
                Array.Copy(arr, extendedArr, count);
                arr = extendedArr;
            }
        }

        public void Add(T item)
        {
            GrowIfArrIsFull();
            arr[count] = item;
            count++;
        }

        public void Insert(int index, T item)
        {
            if (index > count || index < 0)
                throw new IndexOutOfRangeException("Invalid index: " + index);

            GrowIfArrIsFull();
            Array.Copy(arr, index, arr, index + 1, count - index);
            arr[index] = item;
            count++;
        }

        public void Clear()
        {
            arr = new T[INITIAL_CAPACITY];
            count = 0;
        }


        public int IndexOf(T item)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (Equals(item, arr[i]))
                    return i;
            }

            return -1;
        }

        public bool Contains(T item)
        {
            int index = IndexOf(item);
            return index != -1;
        }

        public T this[int index]
        {
            get
            {
                if (index >= count || index < 0)
                    throw new ArgumentOutOfRangeException("Invalid index: " + index);

                return arr[index];
            }

            set
            {
                if (index >= count || index < 0)
                    throw new ArgumentOutOfRangeException("Invalid index: " + index);
                arr[index] = value;
            }
        }

        public T RemoveAt(int index)
        {
            if (index >= count || index < 0)
                throw new ArgumentOutOfRangeException("Invalid index: " + index);

            T item = arr[index];
            Array.Copy(arr, index + 1, arr, index, count - index - 1); // [1,2,3,4] -> [1,3,4,4]
            arr[count - 1] = default(T);
            count--;
            return item;
        }

        public int Remove(T item)
        {
            int index = IndexOf(item);
            if (index != -1)
                RemoveAt(index);
            return index;
        }
    }
}
