using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticTesting
{
    class Test
    {
        public int _y;
        public static int _x;

        public static void static_display()
        {
            Console.WriteLine(_x);
        }

        public void instance_display()
        {
            Console.WriteLine($"x=={_x}, y=={_y}");
        }

        public void setValueToX(int x)
        {
            _x = x;
        }

        public int getValueFromX()
        {
            return _x;
        }
    }
    class Program
    {
        static int _x;
        int _y;
        static void Main(string[] args)
        {
            Test obj = new Test();
            obj.setValueToX(100);

            Test obj2 = new Test();

            Console.WriteLine(Test._x);
        }
    }
}
