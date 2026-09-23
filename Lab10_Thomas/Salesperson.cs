using static System.Console;

//Derived class that inherits from Employee class
public class Salesperson : Employee
{
    //Added fields
    private decimal salesAmount;
    private decimal commissionRate;

    // new constructor that calls base constructor
    public Salesperson(string name, decimal baseSalary, decimal salesAmount, decimal commissionRate) : base(name, baseSalary)
    {
        this.salesAmount = salesAmount;
        this.commissionRate = commissionRate;
    }

    //Overrides base CalculatePay() method
    public override decimal CalculatePay()
    {
        return baseSalary + (salesAmount * commissionRate);
    }
}

