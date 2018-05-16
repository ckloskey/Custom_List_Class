using System;
using System.Collections;
using System.Collections.Generic;

namespace CustomListClass
{
    public class CustomList<T> : IEnumerable <T> where T : IComparable
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
            index = Count == 0 ? 0 : Count;
            arr[index] = value;
            Count++;
        }

        public int FindIndex(T value)
        {
            int itemIndex = -1;
            for (int i = 0; i < Count; i++)
            {
                if (arr[i].Equals(value))
                {
                    itemIndex = i;
                    break;
                }
            }
            return itemIndex;
        }
        public IEnumerator<T> GetEnumerator()
        {
            int index = 0;
            while (index < Count)
            {
                yield return arr[index];
                index++;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public void RemoveAt(int index)
        {
            if (Count > 0)
            { 
                for (int i = index; i < Count; i++)
                {
                    arr[i] = arr[i + 1];
                }
                Count--;
            }
        }

        public void Remove(T value)
        {
            RemoveAt(FindIndex(value));
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
            return string.Format("Last Index {0} is {1}", Count - 1, arr[Count - 1].ToString());
        }

        public static CustomList<T> operator + (CustomList<T> A, CustomList<T> B)
        {
            foreach(T b in B)
            {
                A.Add(b);
            }
            return A;
        }

        public static CustomList<T> operator - (CustomList<T> A, CustomList<T> B)
        {
            int index = A.Count - B.Count;
            for (int i = index; i < (index + B.Count); i++)
            {
                A.RemoveAt(index);
            }
            return A;
        }

        public T [] Zipper(CustomList<T> B)
        {
            int bIndex = Count - 1;
            for (int index = Count - 1; index >= 0; index-- )
            {
                arr[(index * 2)] = arr[index];
                arr[(index * 2) + 1] = B[bIndex];
                bIndex--;
            }
            Count = Count * 2;
            return arr;
        }
    }
}
