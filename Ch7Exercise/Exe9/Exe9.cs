using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

class CountVowelsModularized
{
    static int VowelCount(string text)
    {
        int count = 0;

        foreach(char c in text)
        {
            char lower = char.ToLower(c);
            if (lower == 'a' || lower == 'e' || lower == 'i' || lower == 'o' || lower == 'u')
            {
                count++;
            }
        }
        return count;

    }

    static void Main(string[] args)
    {
        string input = "When you don't know how many arguments of the same data type might eventually be sent to a method, you can declare a parameter array.";

        int countVowel = VowelCount(input);

        Console.WriteLine($"The string contains {countVowel} vowel(s).");
    }
}
