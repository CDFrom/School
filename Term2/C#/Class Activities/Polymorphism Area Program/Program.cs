using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Area_Program
{
	public class Area
	{
		private int a, b, c;
		private double area;
		int ns;
		public Area(int a)
		{
			this.a = a;
			ns = 1;
		}
		public Area(int a, int b)
		{
			this.a = a;
			this.b = b;
			ns = 2;
		}
		public Area(int a, int b, int c)
		{
			this.a = a;
			this.b = b;
			this.c = c;
			ns = 3;
		}
		public void ShowArea()
		{
			if (ns == 1)
			{
				area = a * a;
				Console.WriteLine("Area of a Square of Side Length {0} is: {1}", a, area);
			}
			else if (ns == 2)
			{
				area = a * b;
				Console.WriteLine("Area of a Reatangle of Sides {0} and {1} is: {2}", a, b, area);
			}
			else if (ns == 3)
			{
				double s = (a + b + c) / 2.0;
				area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
				Console.WriteLine("Area of a Triangle of Sides {0}, {1}, and {2} is: {3}", a, b, c, area);
			}
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Area sqr = new Area(5);
			Area rectangle = new Area(3, 4);
			Area triangle = new Area(4, 5, 6);
			sqr.ShowArea();
			rectangle.ShowArea();
			triangle.ShowArea();
		}
	}
}
