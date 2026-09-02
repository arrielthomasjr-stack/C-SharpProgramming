/*Write a program named TestsInteractive that prompts a user for eight test scores and
displays the average of the test scores to two decimal places.*/

using System;

class TestsInteractive
{
    static void Main()
    {
        double totalScore = 0;
        int numberOfTests = 8;

        for (int i = 1; i <= numberOfTests; i++)
        {
            Console.Write($"Enter score for test {i}: ");
            double score = Convert.ToDouble(Console.ReadLine());
            totalScore += score;
        }

        double averageScore = totalScore / numberOfTests;
        Console.WriteLine("The average test score is: {0:F2}", averageScore);
    }
}
