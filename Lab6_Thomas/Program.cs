using System;
using System.Collections;

class RosterAnalyer
{
    static void Main()
    {
        int[] scores = new int[8];

        for (int i = 0; i < scores.Length; i++)
        {
            Console.Write($"Enter score {i + 1}: ");
            while (!int.TryParse(Console.ReadLine(), out scores[i]))
            {
                Console.Write("Invalid entry, try again: ");
            }
        }

        int total = 0;
        foreach (int s in scores)
        {
            total += s;
        }
        double average = (double)total / scores.Length;

        int highest = scores[0];
        int lowest = scores[0];
        for (int i = 1; i < scores.Length; i++)
        {
            if (scores[i] > highest) highest = scores[i];
            if (scores[i] < lowest) lowest = scores[i];
        }

        Console.WriteLine("\n--- Individual Results ---");
        foreach (int s in scores)
        {
            string status = (s >= 60) ? "Pass" : "Fail";
            Console.WriteLine($"{s} - {status}");
        }

        int position = Array.IndexOf(scores, highest);
        Console.WriteLine($"\nHighest score {highest} is at position {position} (score #{position + 1}).");

        Console.WriteLine("\n--- Summary ---");
        Console.WriteLine($"Total:   {total}");
        Console.WriteLine($"Average: {average:F2}");
        Console.WriteLine($"Highest: {highest}");
        Console.WriteLine($"Lowest:  {lowest}");


    }
}