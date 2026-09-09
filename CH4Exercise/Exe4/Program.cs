using System;
using System.Collections;

class Hurricane
{
    static void Main()
    {
        Console.Write("Enter the wind speed in mph: ");
        int windSpeed = Convert.ToInt32(Console.ReadLine());

        if (windSpeed < 74)
        {
            Console.WriteLine("This is not a hurricane.");
        }
        else if (windSpeed >= 74 && windSpeed <= 95)
        {
            Console.WriteLine("The hurricane is a Category 1 hurricane.");
        }
        else if (windSpeed >= 96 && windSpeed <= 110)
        {
            Console.WriteLine("The hurricane is a Category 2 hurricane.");
        }
        else if (windSpeed >= 111 && windSpeed <= 129)
        {
            Console.WriteLine("The hurricane is a Category 3 hurricane.");
        }
        else if (windSpeed >= 130 && windSpeed <= 156)
        {
            Console.WriteLine("The hurricane is a Category 4 hurricane.");
        }
        else
        {
            Console.WriteLine("The hurricane is a Category 5 hurricane.");
        }


    }
}
