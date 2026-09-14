using System;
using System.Collections;

class Library
{
    //Four basic arithmetic methods
    static double Add(double a, double b) => a + b;
    static double Subtract(double a, double b) => a - b;
    static double Multiply(double a, double b) => a * b;

    //Main method to test the arithmetic methods
    static void Main()
    {
        //Divide method with error handling for division by zero
        static double Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error: cannot divide by zero.");
                return double.NaN;
            }
            return a / b;
        }

        //Sum method with params keyword
        static double Sum(params double[] values)
        {
            double total = 0;
            foreach (double v in values)
            {
                total += v;
            }
            return total;
        }

        Console.WriteLine($"Add: {Add(4, 3)}");
        Console.WriteLine($"Subtract: {Subtract(4, 3)}");
        Console.WriteLine($"Multiply: {Multiply(4, 3)}");
        Console.WriteLine($"Divide: {Divide(4, 3)}");
        Console.WriteLine($"Divide by zero test: {Divide(4, 0)}");

        Console.WriteLine($"Sum of 2 values: {Sum(1, 2)}");
        Console.WriteLine($"Sum of 3 values: {Sum(1, 2, 3)}");
        Console.WriteLine($"Sum of 5 values: {Sum(1, 2, 3, 4, 5)}");


    }
}