using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Base
    {
        public int Val { get; set; } = 10;

        public void Display()
        {
            Console.WriteLine("The value is: {0}", Val);
        }

        public override string ToString()
        {
            return "The value is: " + Val;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var b = new Base();

            b.Display();

            Console.WriteLine(b);
        }
    }
}
