using System;

class FahrenheitToCelsius

{
    public static void Main(string[] args)
    {
        Console.Write("Enter temperature in Fahrenheit: ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());

        double celsius = (fahrenheit - 32) * 5 / 9;

        Console.WriteLine($"Temperature from Fahrenheit {fahrenheit} to Celsius: {celsius:F1}");
    }
}