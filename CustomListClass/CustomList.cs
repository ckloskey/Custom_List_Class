using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class CustomList<T> : IEnumerable
    {
        public T[] arr;
        public int capacity;
        private int count;
        int index;
        public CustomList()
        {
            this.capacity = 5;
            this.count = 0;
            arr = new T[capacity];
            this.index = 0;
        }

        public T this[int index]
        {
            get
            {
                return arr[index];
            }
            set
            {
                arr[index] = value;
            }
        }

        public int Capacity
        {
            get
            {
                return capacity;
            }

            set
            {
                capacity = value;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
            set
            {
                count = value;
            }
        }

        public void Add(T value)
        {
            if (index >= arr.Length)
            {
                Capacity++;
                //resize array??
               //throw new IndexOutOfRangeException($"The collection can hold only {arr.Length} elements.");
            }
            arr[index] = value;
            Count++;
            index++;
        }
        public void Remove(T value)
        {

        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

    }
}
