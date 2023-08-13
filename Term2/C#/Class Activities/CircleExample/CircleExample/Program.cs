using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleExample
{
    class Circle
    {
        static int IDCounter = 1;
        public double CenterX;
        public double CenterY;
        public double Radius;
        int ID;

        public Circle()
        {
            CenterX = CenterY = 0;
            Radius = 1;
            ID = IDCounter++;
        }
        public Circle(double centerX, double centerY):this()
        {
            CenterX = centerX;
            CenterY = centerY;
        }
        public Circle(double centerX, double centerY, double radius):this(centerX, centerY)
        {
            Radius = radius;
        }

        ~Circle()
        {
            Console.WriteLine($"Destroying Circle Object: {ID}...");
            Console.WriteLine($"ID = { IDCounter++}");
        }

        public void ShowInfo()
        {
            Console.Write("The information about the circle is: ");
            Console.WriteLine($"ID = {ID}, Center = {{{CenterX}, {CenterY}}}, Radius = {{{Radius}}}.");
        }
    }
    class Program
    {
        static void CreateObjects()
        {
            Circle circle1 = new Circle();
            circle1.ShowInfo();

            Circle circle2 = new Circle();
            circle2.CenterX = 1.0;
            circle2.CenterY = 2.0;
            circle2.ShowInfo();

            Circle circle3 = new Circle(5, 6);
            circle3.ShowInfo();

            Circle circle4 = new Circle(2, 2, 5);
            circle4.ShowInfo();

            Circle circle5 = new Circle() { CenterX = 3, CenterY = 4, Radius = 10 };
            circle5.ShowInfo();
        }
        static void Main(string[] args)
        {
            CreateObjects();

            GC.Collect();
        }
    }
}
