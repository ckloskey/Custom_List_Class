using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class CustomList<T> : Enumerable
    {
        //generic array
        private T[] arr;
        private T[] indexer = new T[100];

        //capacity
        private int capacity;
        public CustomList()
        {
            this.capacity = 5;
            arr = new T[capacity];
        }

        public T this[int capacity]
        {
            get => indexer[capacity];
            set => indexer[capacity] = value;
        }

        public int Capacity { get; set; }
        public T[] Arr { get => arr; set => arr = value; }

        public void Add(T el)
        {
            int newCapacity = this.Capacity + 1;

            for (int i = 0; i < this.Capacity; i++)
            {
                
                arr[newCapacity] = el;

            }

        }
    }
}
