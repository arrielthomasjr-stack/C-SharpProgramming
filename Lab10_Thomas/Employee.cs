using static System.Console;

//Parent or base class
public class Employee
{
    //Feilds
    protected string name;
    protected decimal baseSalary;

    //base constructor
    public Employee(string name, decimal baseSalary)
    {
        this.name = name;
        this.baseSalary = baseSalary;
    }
    //base method that can be overridden
    public virtual decimal CalculatePay()
    {
        return baseSalary;
    }

    //Override for display
    public override string ToString() => $"{name}:  {CalculatePay():C}";
}