using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassByReference
{
    class Program
    {
        static void Swap(out int x, out int y)
        {
            //int t = x;
            x = 1000;
            y = 2000;
        }
        static void Swap(ref int []a)
        {
            a = new int[] { 200, 17 };
            
            /*
            int t = a[0];
            a[0] = a[1];
            a[1] = t;
            */
        }
        static void Main(string[] args)
        {
            int[] a = { 1, 2 };

            Console.WriteLine($"Before swapping at index 0, we have: {a[0]}, at index 1 we have: {a[1]}");
            Swap(ref a);
            Console.WriteLine($"After swapping at index 0, we have: {a[0]}, at index 1 we have: {a[1]}");

            int x, y;
            x = 100;
            y = 1;
            Console.WriteLine($"Before swapping x={x}, y={y}");
            Swap(out x, out y);
            Console.WriteLine($"After swapping x={x}, y={y}");
        }
    }
}
