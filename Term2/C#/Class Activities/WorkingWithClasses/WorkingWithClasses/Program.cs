using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithClasses
{
    class Rectangle
    {
        private double Width;
        private double Height;

        public Rectangle()
        {
            Width = Height = 1;
        }
        public Rectangle(double w, double h)
        {
            Width = w;
            Height = h;
        }
        public void SetWidth(double Width)
        {
            this.Width = Width;
        }
        public double GetWidth()
        {
            return Width;
        }
        public void SetHeight(double Height)
        {
            this.Height = Height;
        }
        public double GetHeight()
        {
            return Height;
        }
        public double GetArea()
        {
            return (Width * Height);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(5,10);
            Console.WriteLine(r.GetArea());
        }
    }
}
