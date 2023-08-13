using System;

namespace GreetingCSharpProgrammers
{
    class Greeting
    {
        public string GetName()
        {
            Console.WriteLine("Please enter your name: ");
            return Console.ReadLine();
        }
        public void Greet(string name)
        {
            Console.WriteLine("Hello {0}! \nWelcome to SODV1202!", name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Greeting obj = new Greeting();

            string name = obj.GetName();
            obj.Greet(name);
        }
    }
}
