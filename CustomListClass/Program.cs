using System;
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
            //for (int i = 1; i <= 3; i++)
            //{
            //    customList.Add(i);
            //}
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(1);
            //customList.Add(2);
            //customList.Add(3);

            customList.Remove(2);

            Console.WriteLine(customList.ToString());

            foreach(int el in customList)
            {
                Console.WriteLine(el);
                
            }
            Console.ReadKey();
        }
    }
}
