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
                if (count >= (Capacity / 2))
                {
                    ResizeArray();
                }
            }
        }

        public void Add(T value)
        {
            arr[index] = value;
            Count++;
            index++;
        }
        public void Remove(T value)
        {
            int itemIndex = -1;
            if (Count > 0)
            { 
                for (int i = 0; i < Count; i++)
                {
                    if (arr[i].Equals(value))
                    {
                        itemIndex = i;
                        break;
                    }
                }

                for (int i = itemIndex; i < Count; i++)
                {
                    arr[i] = arr[i + 1];
                }

                Count--;
            }
        }
        
        public void ResizeArray()
        {
            Capacity = Capacity * 2;
            T[] newArr = new T[capacity];
            for(int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }
            
            arr = newArr;
        }

        public override string ToString()
        {
            return base.ToString();
        }


        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

    }
}
