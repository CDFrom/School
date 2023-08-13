using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPracticeProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Alex is a good student. Programming is fun for Alex. Alexander is Alex's friend.\n" +
                "David ,Alex, and Susan are good at Java programming.\n" +
                "Alexander has a discussion with Alex.\n" +
                "Alex is ambitious and wants to create his/ her career in Software Development.\n" +
                "Alexander is good in programming too. Alex and Alexander are friends.\n";

            Console.WriteLine(str);

            Console.Write("Enter word to replace: ");
            string word1 = Console.ReadLine();
            Console.Write("Enter word to replace with: ");
            string word2 = Console.ReadLine();
            Console.WriteLine();

            string[] words = str.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Contains(word1))
                {
                    string[] check = words[i].Split('.', ',' , '\'');
                    for (int j = 0; j < check.Length; j++)
                    {
                        if (check[j] == word1)
                        {
                            words[i] = words[i].Replace(word1, word2);
                        }
                    }
                }
            }

            str = string.Join(" ", words);

            Console.WriteLine(str);
        }
    }
}
