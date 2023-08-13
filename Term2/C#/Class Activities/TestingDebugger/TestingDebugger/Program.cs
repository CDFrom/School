using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp194
{
    class Program
    {
        static void Display(int p, int q)
        {
            Console.Write("(" + p + "*" + q + ") = ");
        }
        static long MultiplyDisplay(int a, int b)
        {
            Display(a, b);
            long mul = (long)a * b;
            return mul;
        }

        static long AddMultiplyDisplay(int a, int b, int c)
        {
            Console.Write(c + " + ");
            long val = c + MultiplyDisplay(a, b);
            return val;
        }
        static void Main(string[] args)
        {
            int x = 2145376451;

            Console.WriteLine("Current Value of x = {0}\n", x);
            long result = AddMultiplyDisplay(x, 10, 100);
            Console.WriteLine(result);

            Console.WriteLine("\nAfter calculation, result = " + result);


            Console.Read();
        }
    }
}
