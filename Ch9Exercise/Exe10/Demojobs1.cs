using System;

class DemoJobs
{
    static void Main(string[] args)
    {
        
        Job job1 = new Job("wash windows", 3.5, 25.00);
        Job job2 = new Job("mow lawn", 2.0, 20.00);
        Job job3 = new Job("clean gutters", 4.0, 30.00);
        Job job4 = new Job("paint fence", 6.5, 22.50);

        Console.WriteLine("Harold's Home Services -- Job List\n");
        Console.WriteLine(job1);
        Console.WriteLine(job2);
        Console.WriteLine(job3);
        Console.WriteLine(job4);

        // Demonstrate the properties (get and set)
        Console.WriteLine("\nAdjusting job1's hours and rate...");
        job1.HoursToComp = 4.0;      
        job1.PerHourRate = 27.50;     
        Console.WriteLine(job1);

        // Demonstrate the overloaded + operator
        Console.WriteLine("\nCombining job2 and job3 using the + operator:");
        Job combinedJob = job2 + job3;
        Console.WriteLine(combinedJob);

        Console.WriteLine("\nCombining job1 and job4 using the + operator:");
        Job anotherCombinedJob = job1 + job4;
        Console.WriteLine(anotherCombinedJob);

        //New overload//
        Job fairCombo = Job.weightedRate(job1, job2);

        Console.WriteLine("\nCombining job1 and job2 using the New overload:");
        Console.WriteLine(fairCombo);

    }
}