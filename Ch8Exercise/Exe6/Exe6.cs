using System;
using System.Collections.Generic;
using System.Text;

class FineForOverdueBooks
{
    static double CalculateFine(int overdueBooks, int daysOverdue)
    {
        if (daysOverdue <= 7)
        {
            double finePerBookPerDay = 0.10; // Fine per book per day
            return overdueBooks * daysOverdue * finePerBookPerDay;
        }
        else
        {
            double finePerBookPerDay = 0.20; // Fine per book per day
            return overdueBooks * daysOverdue * finePerBookPerDay;
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Enter the number of overdue books: ");
        int overdueBooks = int.Parse(Console.ReadLine());
        
        Console.Write("Enter the number of days overdue: ");
        int daysOverdue = int.Parse(Console.ReadLine());
        
        
        double fine = CalculateFine(overdueBooks, daysOverdue);
        Console.WriteLine($"The total fine is: ${fine:F2}");
    }
    
}

