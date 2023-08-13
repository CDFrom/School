namespace Assignment02
{
    public partial class BasePlusCommissionEmployee : CommissionEmployee
    {
        //Override earnings from base class for appropriate calculation
        public override double Earnings()
        {
            return GrossSales * CommissionRate + BaseSalary;
        }

        //Override UpdateSalary in order to do correct calculation
        //(I believe this can and should simply be changed in the abstract class, but was not sure if I should be making changes to that part of the starter code)
        public override void UpdateSalary(double percent)
        {
            BaseSalary += BaseSalary * (percent / 100);
        }
    }
}