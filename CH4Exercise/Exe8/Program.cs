using System;
using System.Collections;


class GuessingGame
{
    static void Main()
    {
        Console.Write("Enter a number between 1 and 11: ");
        int inputNumber = Convert.ToInt32(Console.ReadLine());

        if (inputNumber >= 1 && inputNumber <= 11)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 12); // Generates a number between 1 and 11

            if (inputNumber == randomNumber)
            {
                Console.WriteLine("Congratulations! You guessed the correct number.");
            }
            else if (inputNumber < randomNumber)
            {
                Console.WriteLine($"Your guess is too low. The correct number was {randomNumber}. Better luck next time!");
            }
            else
            {
                Console.WriteLine($"Your guess is too high. The correct number was {randomNumber}. Better luck next time!");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number between 1 and 11.");
        }
    }
}
