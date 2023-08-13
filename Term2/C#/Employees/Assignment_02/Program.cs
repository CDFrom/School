using System;
using System.Text;

namespace Assignment02
{
    //define and Create 'BasePlusCommissionEmployee' class 
    //{
    //To do
    // define constructor method by matching the total parameters from the main method object instance creation statement  
    // Override the base class earnings method and implement earnings for BasePlusCommissionEmployee class 
    // Override the UpdateSalary method if required.
    // Override ToString() method.                                          
    //}
    //Currently in two separate files BasePlusCommissionEmployee.cs and BasePlusCommissionEmployee1.cs
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Please do not change the content of the main method.
             */

            //Create subclass objects
            SalariedEmployee salariedEmployee = new SalariedEmployee("Mickey Mouse", "111-22-3333", 800.00); //Name, SSN, BaseSalary
            HourlyEmployee hourlyEmployee = new HourlyEmployee("Donald Duck", "111-22-4444", 16.75, 1.5, 50); ////Name, SSN, Wage, OvertimeRate, HoursWorked
            CommissionEmployee commissionEmployee = new CommissionEmployee("Daisy Duck", "444-44-4444", 10000, .06); //Name, SSN, TotalSales, CommissionRate
            BasePlusCommissionEmployee basePlusCommissionEmployee = new BasePlusCommissionEmployee("Goofy Goof", "777-77-7777", 5000, .04, 300); //Name, SSN, TotalSales, CommissionRate, BaseSalary

            //Create an Employee array of base type
            var employees = new Employee[4];
            //Initialize array with different Employees
            employees[0] = salariedEmployee;
            employees[1] = hourlyEmployee;
            employees[2] = commissionEmployee;
            employees[3] = basePlusCommissionEmployee;

            Console.WriteLine("Weekly salary of all employees in the collection:\n");

            //Process every element in the array
            foreach (var currentEmployee in employees)
            {
                Console.WriteLine(currentEmployee); // invokes tostring    
            }

            double percentageIncrease = 30;
            double newCommissionRate = 0.05;
            //Update Salary for BasePlusCommissionEmployee
            //Find BasePlusCommissionEmployee types
            foreach (var currentEmployee in employees)
            { 
                // Check if employee is a BasePlusCommissionEmployee
                if (currentEmployee is BasePlusCommissionEmployee)
                {
                    currentEmployee.UpdateSalary(percentageIncrease); //30% base salary update
                    Console.WriteLine("Base Plus Commission Employee:\nThe new base salary with a {0}% increase is: ${1}", percentageIncrease, currentEmployee.BaseSalary);
                    
                    //Downcast Employee reference to BasePlusCommissionEmployee reference
                    //Downcast is required to access the "CommissionRate" property.
                    BasePlusCommissionEmployee employee = (BasePlusCommissionEmployee) currentEmployee;
                    employee.CommissionRate = newCommissionRate; //New Commission Rate;
                    Console.WriteLine("The new commission rate is: " + employee.CommissionRate+"%");

                } // end if  
            } // end for
            Console.WriteLine();
            //Process every element in the array
            foreach (var currentEmployee in employees)
            {
                Console.WriteLine("Employee {0} is {1}", currentEmployee.Name, currentEmployee.GetType().Name);
                Console.WriteLine("Total Earnings: "+currentEmployee.Earnings());    
            }
        }
    }
}
