/*Modify the Eggs program to create a new one named EggsInteractive that prompts
the user for and accepts a number of eggs for each chicken.*/

using System;

class EggsInteractive
{
    static void Main()
    {
        Console.Write("Chicken 1 has how many eggs: ");
        int numberOfEggs1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Chicken 2 has how many eggs: ");
        int numberOfEggs2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Chicken 3 has how many eggs: ");
        int numberOfEggs3 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Chicken 4 has how many eggs: ");
        int numberOfEggs4 = Convert.ToInt32(Console.ReadLine());


        int totalEggs = numberOfEggs1 + numberOfEggs2 + numberOfEggs3 + numberOfEggs4;
        int dozens = totalEggs / 12;
        int remainingEggs = totalEggs % 12;

        Console.WriteLine("a total of {0} is {1} dozen(s) and {2} egg(s)", totalEggs, dozens, remainingEggs);
    }
}
