using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOdd
{
    class Processor
    {
        public static void GetSum(string [] words)
        {
            int sum = 0;
            for (int i = 1; i < words.Length; i++)
            {
                sum += int.Parse(words[i]);
            }
            Console.WriteLine("Sum is {0}", sum);
        }
        public static void GetProduct(string [] words)
        {
            int product = 1;
            for (int i = 1; i < words.Length; i++)
            {
                product *= int.Parse(words[i]);
            }
            Console.WriteLine("Product is {0}", product);
        }
        public static void IsEven(string [] words)
        {
            int x = int.Parse(words[1]);
            if (x % 2 == 0)
            {
                Console.WriteLine("True.");
            }
            else
            {
                Console.WriteLine("False.");
            }
        }
        public static void IsOdd(string[] words)
        {
            int x = int.Parse(words[1]);
            if (x % 2 == 1)
            {
                Console.WriteLine("True.");
            }
            else
            {
                Console.WriteLine("False.");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string command = "";
            while (command != "exit")
            {
                Console.WriteLine("Enter the command: ");
                command = Console.ReadLine();
                command = command.ToLower().Trim();

                while (command.Contains("  ")) command = command.Replace("  ", " ");
                string[] words = command.Split(' ');

                switch (words[0])
                {
                    case "even":
                        Processor.IsEven(words);
                        break;
                    case "odd":
                        Processor.IsOdd(words);
                        break;
                    case "sum":
                        Processor.GetSum(words);
                        break;
                    case "product":
                        Processor.GetProduct(words);
                        break;
                    case "exit":
                        return;
                    default:
                        Console.WriteLine("Unrecognized command...");
                        Console.WriteLine("Please enter correct command!");
                        break;
                }
            }

            /*
            Console.WriteLine("Enter a number: ");
            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }
            */
        }
    }
}
