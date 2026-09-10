using System;
using System.Collections;


class RockPaperScissors
{
    static void Main()
    {
        Console.Write("Enter your choice (r for rock, p for paper, or s for scissors): ");
        char userChoice = Console.ReadLine().ToLower()[0];

        Random random = new Random();
        int computerChoiceIndex = random.Next(0, 3);
        char[] choices = { 'r', 'p', 's' };
        char computerChoice = choices[computerChoiceIndex];

        Console.WriteLine($"Computer chose: {computerChoice}");

        if (userChoice == computerChoice)
        {
            Console.WriteLine("It's a tie!");
        }
        else if ((userChoice == 'r' && computerChoice == 's') ||
                 (userChoice == 'p' && computerChoice == 'r') ||
                 (userChoice == 's' && computerChoice == 'p'))
        {
            Console.WriteLine("You win!");
        }
        else
        {
            Console.WriteLine("Computer wins!");
        }
    }
}
