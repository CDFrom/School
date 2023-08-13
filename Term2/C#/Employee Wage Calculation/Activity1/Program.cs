using System;

namespace ConsoleApp1
{
    class Employee
    {
        //To do
        //Declare your member variables and initialize values (if required) here.

        public string Name;
        public double Rate;
        public double Hours;
        public double Owed; //I don't know that you actually need this variable unless wage is going to be updated in between payments
                            //However due to the rest of the requests from the comments figured I would add this one in

        public void SetName(string name)
        {
            //To do
            //Set name to a member variable/field.

            Name = name;
        }
        public string GetName()
        {
            //To do
            //return the member variable correspond to the name attribute.

            return Name;
        }

        public void SetWage(double rate)
        {
            //To do
            //set wage

            Rate = rate;
        }
        public void Work(double hours)
        {
            //To do
            //Update unpaid hours
            //Calculate money Owed.

            Hours += hours;
            Owed += Rate * hours; //Could be ignored as mentioned in the declaration area, check Pay function for further logic
        }
        public double Pay()
        {
            //To do
            // return moneyOwed and set unpaid hours and moneyOwed to zero

            //var paid = Rate * Hours; We need to create a variable anyway to save and return what needs to be paid without returning a 0 after setting Hours to 0
            //Therefore in my mind we could use this instead of having the Owed variable
            //HOWEVER if there were to be a change in rate before said person had been paid it would give the incorrect amount so I can see a reason for having the Owed parameter
            var paid = Owed;
            Hours = 0;
            Owed = 0;
            return paid;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            Employee emp2 = new Employee();

            emp1.SetName("David");
            emp1.SetWage(15);
            emp2.SetName("Susan");
            emp2.SetWage(30);

            var amount = emp1.Pay();
            Console.WriteLine("Employee '{0}' is paid {1} before working...", emp1.GetName(), emp1.Pay());
            Console.WriteLine("Employee '{0}' is paid {1} before working...", emp2.GetName(), emp2.Pay());
            emp1.Work(5);
            emp2.Work(8);
            Console.WriteLine("Employee '{0}' is paid {1} after working...", emp1.GetName(), emp1.Pay());

            emp1.Work(5);
            emp2.Work(2);
            Console.WriteLine("Employee '{0}' is paid {1} after working...", emp1.GetName(), emp1.Pay());
            Console.WriteLine("Employee '{0}' is paid {1} after working...", emp2.GetName(), emp2.Pay());
        }
    }
}
