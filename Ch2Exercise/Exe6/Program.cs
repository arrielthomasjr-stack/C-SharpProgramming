/*Convert the InchesToCentimeters program to an interactive application named
InchesToCentimetersInteractive. Instead of assigning a value to the inches variable,
accept the value from the user as input.*/
using System;
class InchesToCentimetersInteractive
{
    static void Main()
    {
        Console.Write("Enter the number of inches: ");
        double inches = Convert.ToDouble(Console.ReadLine());
        double centimeters = inches * 2.54;
        Console.WriteLine("{0} inches = {1} centimeters", inches, centimeters);
    }
}
