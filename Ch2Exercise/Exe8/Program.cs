/*Convert the ProjectedRaises class to an interactive application named
ProjectedRaisesInteractive. Instead of assigning values to the salaries, accept them
from the user as input.*/
using System;

class ProjectedRaisesInteractive
{
    static void Main()
    {
        Console.Write("Enter the first salary: ");
        double salary1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the second salary: ");
        double salary2 = Convert.ToDouble(Console.ReadLine());
        

        double raise1 = salary1 * 0.05;
        double raise2 = salary2 * 0.05;
        
        Console.WriteLine("Projected raises:");
        Console.WriteLine("First salary raise: {0}", raise1);
        Console.WriteLine("Second salary raise: {0}", raise2);
        
    }
}
