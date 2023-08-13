using System;
namespace Activity_04
{
    public class Point
    {
        public double x;
        public double y;
    }

    public abstract class Shape
    {
        public Point Centre { get; set; } = new Point();

        public Shape(double x, double y)
        {
            //set Center point to parameter values
            Centre.x = x;
            Centre.y = y;
        }

        public void Move(double dx, double dy)
        {
            //increment center to dx and dy amount.
            Centre.x += dx;
            Centre.y += dy;
        }

        public abstract double GetArea();
        public abstract double GetPerimeter();

        public bool IsSmallerThan(Shape other)
        {
            // return true if this objects's area is smaller that parameter objects's area.
            if (GetArea() < other.GetArea()) return true;
            // return flase otherwise.
            else return false;
        }
    }

    public class Rectangle : Shape
    {
        //To Do
        //Rectangle needs a height and width property
        public double Width { get; set; }
        public double Height { get; set; }
        //Constructor function to get coordinates and set height and width, use base constructor for coordinates
        public Rectangle(double x, double y, double width, double height) : base(x, y)
        {
            Width = width;
            Height = height;
        }
        //Override the abstract method and use the formula for area of a rectangle
        public override double GetArea()
        {
            return Width * Height;
        }
        //Override the abstract method and use the formula for perimeter of a rectangle
        public override double GetPerimeter()
        {
            return (Width + Height) * 2;
        }
    }

    public class Circle : Shape
    {
        //To Do
        //Circle needs a radius property
        public double Radius { get; set; }
        //Constructor function to get coordinates and set radius, use base constructor for coordinates
        public Circle(double x, double y, double radius) : base(x, y)
        {
            Radius = radius;
        }
        //Override the abstract method and use the formula for area of a circle
        public override double GetArea()
        {
            return Math.PI * (Radius * Radius);
        }
        //Override the abstract method and use the formula for perimeter(circumference) of a circle
        public override double GetPerimeter()
        {
            return Math.PI * (Radius * 2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int shapeCount = Int32.Parse(Console.ReadLine());
            var shapes = new Shape[shapeCount];
            for (int i = 0; i < shapeCount; ++i)
            {
                var cmd = Console.ReadLine().Split();
                if (cmd[0] == "rectangle")
                {
                    double x = double.Parse(cmd[1]);
                    double y = double.Parse(cmd[2]);
                    double width = double.Parse(cmd[3]);
                    double height = double.Parse(cmd[4]);
                    shapes[i] = new Rectangle(x, y, width, height);
                }
                else if (cmd[0] == "circle")
                {
                    double x = double.Parse(cmd[1]);
                    double y = double.Parse(cmd[2]);
                    double radius = double.Parse(cmd[3]);
                    shapes[i] = new Circle(x, y, radius);
                }
            }
            string input;
            while ((input = Console.ReadLine()) != "exit")
            {
                var cmd = input.Split();
                if (cmd[0] == "move")
                {
                    int index = int.Parse(cmd[1]);
                    double dx = double.Parse(cmd[2]);
                    double dy = double.Parse(cmd[3]);
                    shapes[index].Move(dx, dy);
                }
                else if (cmd[0] == "centre")
                {
                    int index = int.Parse(cmd[1]);
                    Console.WriteLine(shapes[index].Centre.x + ", " + shapes[index].Centre.y);
                }
                else if (cmd[0] == "area")
                {
                    int index = int.Parse(cmd[1]);
                    Console.WriteLine(shapes[index].GetArea());
                }
                else if (cmd[0] == "perimeter")
                {
                    int index = int.Parse(cmd[1]);
                    Console.WriteLine(shapes[index].GetPerimeter());
                }
                else if (cmd[0] == "issmaller")
                {
                    int index1 = int.Parse(cmd[1]);
                    int index2 = int.Parse(cmd[2]);
                    Console.WriteLine(shapes[index1].IsSmallerThan(shapes[index2]));
                }
            }
        }
    }
}