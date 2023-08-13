namespace Assignment02
{
    public class SalariedEmployee : Employee
    {
        // three-argument constructor
        public SalariedEmployee(string name, string ssn, double salary) : base(name, ssn)
        {
            BaseSalary = salary; // Set weekly salary
        }

        //Must Override base class method                                                           
        public override double Earnings()
        {
            return BaseSalary;
        }

        //Overriding BaseClass ToString Method                                                    
        public override string ToString()
        {
            string s = "Salaried employee: " + base.ToString() + "\nWeekly salary " + string.Format("${0:0.00}", BaseSalary) + string.Format("\nEarnings ${0:0.00}", Earnings()) + "\n";
            return s;
        }
                                            
    }
}