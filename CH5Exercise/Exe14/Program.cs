/*In Chapter 4, you created a program that generates a random number, allows a user to
guess it, and displays a message indicating whether the guess is too low, too high, or
correct. Now, create a modified program called GuessingGame2 in which the user
can continue to enter values until the correct guess is made. After the user guesses
correctly, display the number of guesses made.*/

using System;
using System.Collections;

class GuessingGame2
{
    static void Main()
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 12); // Generates a number between 1 and 11
        int guessCount = 0;
        bool guessedCorrectly = false;

        while (!guessedCorrectly)
        {
            Console.Write("Enter a number between 1 and 11: ");
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            guessCount++;

            if (inputNumber >= 1 && inputNumber <= 11)
            {
                if (inputNumber == randomNumber)
                {
                    Console.WriteLine($"Congratulations! You guessed the correct number in {guessCount} guesses.");
                    guessedCorrectly = true;
                }
                else if (inputNumber < randomNumber)
                {
                    Console.WriteLine("Your guess is too low. Try again.");
                }
                else
                {
                    Console.WriteLine("Your guess is too high. Try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 11.");
            }
        }
    }
}