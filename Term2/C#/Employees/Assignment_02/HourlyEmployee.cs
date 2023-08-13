namespace Assignment02
{
    //define and Create 'HourlyEmployee' class 
    //{
    //To do
    // define property for 'wage', 'hours', and overtimeRate
    // define constructor method by matching the total parameters from the main method object instance creation statement  
    // Override the base class earnings method and implement earnings for HourlyEmployee class   
    // Override ToString() method.                                                                                                   
    //}
    public class HourlyEmployee : Employee
    {
        //ToDo
        //Create appropriate properties for the class
        public double Wage { get; set; }
        public int Hours { get; set; }
        public double OvertimeRate { get; set; }

        //Assign values accordingly and use the base class constructor (Employee) where applicable
        public HourlyEmployee(string name, string ssn, double wage, double overtimeRate, int hours) : base(name, ssn)
        {
            Wage = wage;
            OvertimeRate = overtimeRate;
            Hours = hours;
        }

        //Override the Earnings method from base class for appropriate calculation
        public override double Earnings()
        {
            double earnings;
            if (Hours > 40) //Check if employee has worked overtime (Hours after 40 hours)
            {
                earnings = Wage * 40;
                earnings += Wage * OvertimeRate * (Hours - 40);
            }
            else //If not overtime is worked
            {
                earnings = Hours * Wage;
            }
            return earnings;
        }

        //Override ToString method for correct output
        public override string ToString()
        {
            return $"Hourly Employee: " +
                base.ToString() +
                $"\nHourly Salary ${Wage}, Hours Worked {Hours}" +
                $"\nEarnings ${Earnings()}\n";
        }
    }
}