using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        //Creating an array of Employees
        Employee[] staff = new Employee[]
        {
            new Employee("Sam Carter", 40000m),
            new Manager("Grace Hooper", 60000m, 5000m),
            new Salesperson("Max Diaz", 30000m, 120000m, 0.05m),
            new Manager("Todd Heinz", 60000m, 5000m)
        };
         //Header for the print display
        WriteLine("---  Payroll Report  ---");
        //Iterate through Employees array initialized as "staff"
        foreach (Employee e in staff)
        {
            //Displaying them in the order they were created
            WriteLine(e);
        }
    }
}
    
