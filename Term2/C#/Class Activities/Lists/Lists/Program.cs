using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>();

            myList.Add(2);
            myList.Add(3);
            myList.Add(5);

            myList.Insert(1, 11);
            myList.Remove(5);
            myList.Sort();

            Console.WriteLine("Elements inside the list: ");
            for(int i = 0; i < myList.Count; i++)
            {
                Console.Write(myList[i] + " ");
            }
            Console.WriteLine();

            /*
            foreach (var item in myList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            */

            /*
            myList.Reverse();

            Console.WriteLine("Elements inside the list in reverse order: ");
            for (int i = 0; i < myList.Count; i++)
            {
                Console.Write(myList[i] + " ");
            }

            Console.WriteLine();
            */
        }
    }
}
