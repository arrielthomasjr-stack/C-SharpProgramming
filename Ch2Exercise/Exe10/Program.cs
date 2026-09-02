/*Write a program named HoursAndMinutes that declares a minutes variable to
represent minutes worked on a job, and assign a value to it. Display the value in hours
and minutes. For example, 197 minutes becomes 3 hours and 17 minutes.*/

using System;

class HoursAndMinutes
{
    static void Main()
    {
        int MinutesWorked = 200;
        int hours = MinutesWorked / 60;
        int minutes = MinutesWorked % 60;

        Console.WriteLine("{0} hours and {1} minutes is equal to {2} total minutes.", hours, minutes, MinutesWorked);
    }
}
