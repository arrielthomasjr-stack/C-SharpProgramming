/*Write a program named ArrayDemo that stores an array of 10 integers. Until the user
enters a sentinel value, allow the user four options: (1) to view the list in order from
the first to last position in the stored array, (2) to view the list in order from the last to
first position, (3) to choose a specific position to view, or (4) to quit the application.*/

using System;
using System.Collections;

class ArrayDemo
{
    static void Main()
    {
        int[] numbers = new int[10];
        int count = 0;
        int choice;

        do
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. View list from first to last");
            Console.WriteLine("2. View list from last to first");
            Console.WriteLine("3. View specific position");
            Console.WriteLine("4. Quit");
            Console.Write("Enter your choice (1-4): ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("List from first to last:");
                    for (int i = 0; i < count; i++)
                    {
                        Console.WriteLine(numbers[i]);
                    }
                    break;
                case 2:
                    Console.WriteLine("List from last to first:");
                    for (int i = count - 1; i >= 0; i--)
                    {
                        Console.WriteLine(numbers[i]);
                    }
                    break;
                case 3:
                    Console.Write("Enter the position (0-9): ");
                    int position = Convert.ToInt32(Console.ReadLine());
                    if (position >= 0 && position < count)
                    {
                        Console.WriteLine($"Value at position {position}: {numbers[position]}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid position.");
                    }
                    break;
                case 4:
                    Console.WriteLine("Exiting the application.");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            if (choice != 4 && count < numbers.Length)
            {
                Console.Write("Enter an integer to store in the array: ");
                numbers[count] = Convert.ToInt32(Console.ReadLine());
                count++;
            }

        }

        while (choice != 4);
    }
}