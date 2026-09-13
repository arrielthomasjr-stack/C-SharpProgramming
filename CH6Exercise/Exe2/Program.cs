/*Write a program named TestScoreList that accepts eight int values representing
student test scores. Display each of the values along with a message that indicates how
far it is from the average.*/

using System;
using System.Collections;

class TestScoreList
{
    static void Main()
    {
        int[] scores = new int[8];
        int total = 0;

        for (int i = 0; i < scores.Length; i++)
        {
            Console.Write($"Enter test score {i + 1}: ");
            scores[i] = Convert.ToInt32(Console.ReadLine());
            total += scores[i];
        }

        double average = (double)total / scores.Length;
        Console.WriteLine($"\nAverage score: {average:F2}\n");

        for (int i = 0; i < scores.Length; i++)
        {
            double difference = scores[i] - average;
            Console.WriteLine($"Score {scores[i]} is {(difference >= 0 ? "+" : "")}{difference:F2} from the average.");
        }
    }
}