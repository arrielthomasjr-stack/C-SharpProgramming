/*Write a program named CountVowels that accepts a phrase from the user and counts
the number of vowels in the phrase. For this exercise, count both uppercase and
lowercase vowels, but do not consider y to be a vowel.*/

using System;
using System.Collections;

class CountVowels
{
    static void Main()
    {
        Console.Write("Enter a phrase: ");
        string phrase = Console.ReadLine();

        int vowelCount = 0;

        foreach (char c in phrase)
        {
            if ("aeiouAEIOU".IndexOf(c) >= 0)
            {
                vowelCount++;
            }
        }

        Console.WriteLine($"The number of vowels in the phrase is: {vowelCount}");
    }
}