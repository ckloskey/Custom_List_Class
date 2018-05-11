using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class CustomList<T>
    {
        private T[] arr;
        private T[] indexer = new T[100];
        private int capacity;
        public CustomList()
        {
            this.capacity = 0;
            arr = new T[capacity];
        }

        public T this[int capacity]
        {
            get
            {
                return indexer[capacity];
            }

            set
            {
                indexer[capacity] = value;
            }
        }

        public int Capacity { get; set; }
        public T[] Arr { get => arr; set => arr = value; }

        public T[] Add(T newValue)
        {
            Capacity = Capacity + 1;
            T[] newArr = new T[Capacity];
            for (int i = 0; i < Arr.Length; i++)
            {
                newArr[i] = arr[i];
            }
            newArr[Capacity - 1] = newValue;
            Arr = newArr;
            return newArr;
        }
    }
}
