using System;

const int secretNumber = 42;
int guessCount = 0;
int guess;

do
{
    Console.Write("Guess the secret number (between 1 and 100): ");
    string input = Console.ReadLine();

    if (!int.TryParse(input, out guess))
    {
        Console.WriteLine("Please enter a whole number.");
        continue;
    }
    guessCount++;
    if (guess < secretNumber)
    {
        Console.WriteLine("Too low! Try again.");
    }
    else if (guess > secretNumber)
    {
        Console.WriteLine("Too high! Try again.");
    }
    else
    {
        Console.WriteLine("You got it!");
        Console.WriteLine($"Congratulations! You've guessed the secret number {secretNumber} in {guessCount} attempts.");
    }
} 

while (guess != secretNumber);
