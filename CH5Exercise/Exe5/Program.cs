/*Danielle, Edward, and Francis are three salespeople at Holiday Homes. Write an
application named HomeSales that prompts the user for a salesperson initial (D, E,
or F ). Either uppercase or lowercase initials are valid. While the user does not type Z,
continue by prompting for the amount of a sale. Issue an error message for any invalid
initials entered. Keep a running total of the amounts sold by each salesperson. After
the user types Z or z for an initial, display each salesperson’s total, a grand total for all
sales, and the name of the salesperson with the highest total.*/

using System;
using System.Collections;

class HomeSales
{
    static void Main()
    {
        double totalD = 0, totalE = 0, totalF = 0;
        char initial;

        do
        {
            Console.Write("Enter salesperson initial (D, E, F) or Z to quit: ");
            initial = Char.ToUpper(Console.ReadLine()[0]);

            if (initial == 'Z')
                break;

            if (initial != 'D' && initial != 'E' && initial != 'F')
            {
                Console.WriteLine("Invalid initial. Please enter D, E, F, or Z.");
                continue;
            }

            Console.Write("Enter sale amount: ");
            double saleAmount = Convert.ToDouble(Console.ReadLine());

            switch (initial)
            {
                case 'D':
                    totalD += saleAmount;
                    break;
                case 'E':
                    totalE += saleAmount;
                    break;
                case 'F':
                    totalF += saleAmount;
                    break;
            }

        }

        while (true);

        double grandTotal = totalD + totalE + totalF;

        Console.WriteLine($"\nTotal sales for D: {totalD:C}");
        Console.WriteLine($"Total sales for E: {totalE:C}");
        Console.WriteLine($"Total sales for F: {totalF:C}");
        Console.WriteLine($"Grand total sales: {grandTotal:C}");

        if (totalD > totalE && totalD > totalF)
            Console.WriteLine("Salesperson D has the highest total.");
        else if (totalE > totalD && totalE > totalF)
            Console.WriteLine("Salesperson E has the highest total.");
        else if (totalF > totalD && totalF > totalE)
            Console.WriteLine("Salesperson F has the highest total.");
        else
            Console.WriteLine("There is a tie for the highest sales.");
    }
}