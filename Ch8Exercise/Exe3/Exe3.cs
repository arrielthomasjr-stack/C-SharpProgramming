using System;
using System.Collections.Generic;

class PaintingEstimate
{
    static double estimateCost(double length, double width)
    {
        double height = 9; // Assume a standard ceiling height of 9 feet
        // Calculate the total square footage to be painted
        double totalSquareFootage = 2 * (length * height + width * height);
        // Calculate the total cost of painting (assuming $6 per square foot)
        double totalcost = totalSquareFootage * 6;
        return totalcost;
    }
    static void Main(string[] args)
    {
        // Get the dimensions of the room from the user
        Console.Write("Enter the length of the room in feet:");
        double length = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the width of the room in feet:");
        double width = Convert.ToDouble(Console.ReadLine());
        
        double cost = estimateCost(length, width);
        // Display the results to the user

        Console.WriteLine($"Estimated cost of paint: {cost:F2}");
    }

    
}