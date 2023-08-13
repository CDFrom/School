namespace Assignment02
{
    public partial class BasePlusCommissionEmployee : CommissionEmployee
    {
        //ToDo
        //Assign values accordingly and use the base class constructor (Commission Employee) where applicable
        public BasePlusCommissionEmployee(string name, string ssn, double grossSales, double commissionRate, double baseSalary) : base(name, ssn, grossSales, commissionRate)
        {
            BaseSalary = baseSalary;
        }

        //Override ToString for correct output
        public override string ToString()
        {
            return $"Base Plus Comission Employee: {Name}" +
                $"\nSocial security number: {Ssn}" +
                $"\nGross Sales ${GrossSales}, Commission Rate {CommissionRate}%, Base Salary ${BaseSalary}" +
                $"\nEarnings ${Earnings()}\n";
        }
    }
}