using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerPhoneRegistration
{
    class Customer
    {
        string _name;
        string _number;
        public string Name { get => formatName(); set => _name = value; }
        public string Number { get => $"{_number.Substring(0, 3)}-{_number.Substring(3, 3)}-{_number.Substring(6)}"; set => _number = value; }

        public string formatName()
        {
            string[] nameParts = _name.Split(' ');
            string lName = nameParts[nameParts.Length - 1];
            return $"{_name[0].ToString().ToUpper()}. {lName}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Customer person = new Customer();
            Console.Write("Please enter your name: ");
            person.Name = Console.ReadLine();
            Console.Write("Please enter your phone number: ");
            person.Number = Console.ReadLine();
            Console.WriteLine($"\nWelcome {person.Name}, your contact number: {person.Number}");
        }
    }
}
