/*Write a program for The Carefree Resort named ResortPrices that prompts the user
to enter the number of days for a resort stay. Then display the price per night and the
total price. Nightly rates are $200 for one or two nights; $180 for three or four nights;
$160 for five, six, or seven nights; and $145 for eight nights or more.*/

using System;
using System.Collections;

class ResortPrices
{
    static void Main()
    {
        Console.Write("Enter the number of days for your resort stay: ");
        int numberOfDays = Convert.ToInt32(Console.ReadLine());

        int pricePerNight;

        if (numberOfDays == 1 || numberOfDays == 2)
        {
            pricePerNight = 200;
        }
        else if (numberOfDays == 3 || numberOfDays == 4)
        {
            pricePerNight = 180;
        }
        else if (numberOfDays >= 5 && numberOfDays <= 7)
        {
            pricePerNight = 160;
        }
        else // For eight nights or more
        {
            pricePerNight = 145;
        }

        int totalPrice = pricePerNight * numberOfDays;

        Console.WriteLine($"Price per night: ${pricePerNight}");
        Console.WriteLine($"Total price for {numberOfDays} nights: ${totalPrice}");
    }
}

