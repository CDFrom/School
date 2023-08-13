using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingConstructors
{
    class A
    {
        public int a;

        public int value = 1;

        public A()
        {
            //Console.WriteLine("Default Constructor A");
        }

        public A(int x)
        {
            //Console.WriteLine("Paramaterized Constructor A");
        }
        public virtual void Display()
        {
            Console.WriteLine("Display from Class A");
        }
    }
    class B : A
    {
        public int a;

        public int value = 5;

        public B()
        {
            //Console.WriteLine("Default Constructor B");
        }

        public B(int x)
        {
            //Console.WriteLine("Paramaterized Constructor B");
        }
        public override void Display()
        {
            int value=100;
            //base.Display();
            Console.WriteLine("Display from Class B");

            //Console.WriteLine("Value = " + value);
            //Console.WriteLine("This Value = " + this.value);
            //Console.WriteLine("Base Value = " + base.value);

            value = 5; //local scope
            this.value = 5; //Current Class
            base.value = 5; //Super/Parent Class
        }
    }
    class C : B
    {
        public override void Display()
        {
            Console.WriteLine("Display from Class C");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A(1);
            B b = new B();
            C c = new C();

            A obj;
            obj = c;

            obj.Display();
        }
    }
}
