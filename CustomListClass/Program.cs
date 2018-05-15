﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> customList = new CustomList<int>();
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(1);

            customList.Remove(2);

            foreach (int el in customList)
            {
                Console.WriteLine(el);
            }

            Console.WriteLine(customList); //actually changed this to use this for testing purposes

            CustomList<int> customList2 = new CustomList<int>() { 1, 2, 3 };
            customList = customList + customList2;
            Console.WriteLine(customList);

            customList = customList - customList2;
            Console.WriteLine(customList);

            //customList.Zipper(customList2);

            CustomList<int> customList3 = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> customList4 = new CustomList<int>() { 1, 2, 3, 4, 5 };

            customList3.Zipper(customList4);
            Console.WriteLine(customList3);
            Console.ReadKey();
        }
    }
}
