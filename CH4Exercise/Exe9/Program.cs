using System;
using System.Collections;

class Lottery
{
    static void Main()
    {
        Random random = new Random();
        int num1 = random.Next(1, 5); // Generates a one-digit lottery number
        int num2 = random.Next(1, 5); // Generates a one-digit lottery number
        int num3 = random.Next(1, 5); // Generates a one-digit lottery number

        // Get the user's three guesses
        Console.Write("Enter guess #1 (1-4): ");
        int guess1 = int.Parse(Console.ReadLine());

        Console.Write("Enter guess #2 (1-4): ");
        int guess2 = int.Parse(Console.ReadLine());

        Console.Write("Enter guess #3 (1-4): ");
        int guess3 = int.Parse(Console.ReadLine());

        // Put guesses and winning numbers into arrays
        int[] guesses = { guess1, guess2, guess3 };
        int[] winning = { num1, num2, num3 };

        // Keep track of which winning numbers have already been "used"
        // so repeating digits don't get double credit
        bool[] used = { false, false, false };

        int matches = 0;

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (!used[j] && guesses[i] == winning[j])
                {
                    matches++;
                    used[j] = true; // mark this winning number as used
                    break;
                }
            }
        }
        // Check if the guess matches in exact order
        bool exactOrder = (guess1 == num1 && guess2 == num2 && guess3 == num3);

        // Determine the award
        int award = 0;

        if (exactOrder)
            award = 10000;
        else if (matches == 3)
            award = 1000;
        else if (matches == 2)
            award = 100;
        else if (matches == 1)
            award = 10;
        else
            award = 0;

        // Display the results
        Console.WriteLine();
        Console.WriteLine("Your guess:      " + guess1 + ", " + guess2 + ", " + guess3);
        Console.WriteLine("Winning numbers: " + num1 + ", " + num2 + ", " + num3);
        Console.WriteLine("You win: $" + award);
    }
}