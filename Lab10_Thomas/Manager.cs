using static System.Console;

//Derived class that inherits from Employee class
public class Manager : Employee
{
    //Added field
    private decimal bonus;

    //new constructor that call base class constructor
    public Manager(string name, decimal baseSalary, decimal bonus) : base(name, baseSalary)
    {
        
        this.bonus = bonus;
    }

    //Override method of CalculatePay() from base method
    public override decimal CalculatePay()
    {
        return baseSalary + bonus;
    }

}

