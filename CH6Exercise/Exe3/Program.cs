/*Write a program named TemperaturesComparison that allows a user to input five
daily Fahrenheit temperatures that must range from −30 to 130; if a temperature
is out of range, require the user to reenter it. If no temperature is lower than any
previous one, display a message Getting warmer. If every temperature is lower than
the previous one, display a message Getting cooler. If the temperatures are not entered
in either ascending or descending order, display a message It’s a mixed bag. Finally,
display the temperatures in the order they were entered, and then display the average
of the temperatures.*/

using System;
using System.Collections;


class TemperaturesComparison
{
    static void Main()
    {
        int[] temperatures = new int[5];
        int count = 0;
        bool isGettingWarmer = true;
        bool isGettingCooler = true;

        do
        {
            Console.Write($"Enter temperature {count + 1} (between -30 and 130): ");
            int temp = Convert.ToInt32(Console.ReadLine());

            if (temp < -30 || temp > 130)
            {
                Console.WriteLine("Temperature out of range. Please reenter.");
                continue;
            }

            temperatures[count] = temp;

            if (count > 0)
            {
                if (temperatures[count] < temperatures[count - 1])
                {
                    isGettingWarmer = false;
                }
                else if (temperatures[count] > temperatures[count - 1])
                {
                    isGettingCooler = false;
                }
            }
            count++;
        } while (count < 5);

        if (isGettingWarmer)
        {
            Console.WriteLine("Getting warmer.");
        }
        else if (isGettingCooler)
        {
            Console.WriteLine("Getting cooler.");
        }
        else
        {
            Console.WriteLine("It's a mixed bag.");
        }

        Console.WriteLine("Temperatures in order entered:");
        for (int i = 0; i < temperatures.Length; i++)
        {
            Console.Write($"{temperatures[i]} ");
        }
        Console.WriteLine();

        double average = temperatures.Average();
        Console.WriteLine($"Average temperature: {average:F2}");
    }
}