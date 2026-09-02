/*Write a program named MakeChange that calculates and displays the conversion of
an entered number of dollars into currency denominations—twenties, tens, fives, and
ones. For example, $113 is 5 twenties, 1 ten, 0 fives, and 3 ones.*/

using System;

class MakeChange
{
    static void Main()
    {
        Console.Write("Enter the amount in dollars: ");
        int dollars = Convert.ToInt32(Console.ReadLine());
        int dollarsInput = dollars; // Store the original input for display

        int twenties = dollars / 20;
        dollars %= 20;

        int tens = dollars / 10;
        dollars %= 10;

        int fives = dollars / 5;
        dollars %= 5;

        int ones = dollars / 1;
        dollars %= 1;

        Console.WriteLine(" ${0} is {1} twenties, {2} tens, {3} fives, {4} ones", dollarsInput, twenties, tens, fives, ones);
    }
}
