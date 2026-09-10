using System;

//User input for a score between 0 and 100, then output the corresponding letter grade based on the following scale:
Console.Write("Enter a score (0-100): ");
string input = Console.ReadLine();

// Validate the input and determine the letter grade
if (int.TryParse(input, out int score) && score >= 0 && score <= 100)
{
    // Determine the letter grade based on the score
    char grade;
    if (score >= 90) grade = 'A';
    else if (score >= 80) grade = 'B';
    else if (score >= 75) grade = 'C';
    else if (score >= 60) grade = 'D';
    else grade = 'F';

    // Output the letter grade
    Console.WriteLine($"Grade: {grade}");

}
else
{
    // Handle invalid input
    Console.WriteLine("Please enter a whole number from 0 to 100.");
}