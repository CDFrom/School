namespace Assignment02
{
    //define and Create 'CommissionEmployee' class 
    //{
    //To do
    // define property for 'GrossSales' and 'CommitionRate'
    // define constructor method by matching the total parameters from the main method object instance creation statement  
    // Override the base class earnings method and implement earnings for CommissionEmployee class
    // Override ToString() method.
    //}
    public class CommissionEmployee : Employee
    {
        //ToDo
        //Create appropriate properties for the class
        public double GrossSales { get; set; }
        public double CommissionRate { get; set; }

        //Assign values accordingly and use the base class constructor (Employee) where applicable
        public CommissionEmployee(string name, string ssn, double grossSales, double commissionRate) : base(name, ssn)
        {
            GrossSales = grossSales;
            CommissionRate = commissionRate;
        }

        //Override earnings from base class for appropriate calculation
        public override double Earnings()
        {
            return GrossSales * CommissionRate;
        }

        //Override ToString for correct output
        public override string ToString()
        {
            return $"Commission Employee: " +
                base.ToString() +
                $"\nGross Sales ${GrossSales}, Commission Rate {CommissionRate}%" +
                $"\nEarnings ${Earnings()}\n";
        }
    }
}