namespace Assignment02
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public string Ssn { get; set; }
        public double BaseSalary { get; set; }

        // two-argument constructor
        public Employee(string name, string ssn)
        {
            Name = name;
            Ssn = ssn;
            BaseSalary = 0;
        }

        //Virtual Method Default Behavior: update the salary
        public virtual void UpdateSalary(double percent)
        {
            BaseSalary = BaseSalary + BaseSalary * percent;

        }

        //Overriding Object Class ToString() method...
        public override string ToString()
        {
            return Name + "\nSocial security number: " + Ssn;

        }

        // abstract method will be overridden by inherited subclasses        
        public abstract double Earnings();
        // no implementation is allowed here, derived calss must override this method!
    }   
}