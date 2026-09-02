/*Malcolm Movers charges a base rate of $200 per move plus $150 per hour and $2 per
mile. Write a program named MoveEstimator that prompts a user for and accepts
estimates for the number of hours for a job and the number of miles involved in the
move and displays the total moving fee.*/

using System;

class MoveEstimator
{
    static void Main()
    {
        Console.Write("Enter the number of hours: ");
        double numberHours = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the distance in miles: ");
        double distance = Convert.ToDouble(Console.ReadLine());

        double costPerMove = 200.0; // Cost per move
        double costPerHour = 150.0; // Cost per hour
        double costPerMile = 2.0; // Cost per mile

        double totalCost = ((numberHours * costPerHour) + (distance * costPerMile)) + costPerMove;

        Console.WriteLine("Estimated moving cost: ${0}", totalCost);
    }
}

