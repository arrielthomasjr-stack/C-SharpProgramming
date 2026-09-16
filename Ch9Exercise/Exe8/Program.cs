using System;

class ConferencesDemo
{

    static void Main()
    {
        const int NUM_CONFERENCES = 5;
        Conference[] conferences = new Conference[NUM_CONFERENCES];

        // Gather data for five Conference objects from the user
        for (int i = 0; i < NUM_CONFERENCES; i++)
        {
            Console.WriteLine("\nEnter data for conference #{0}", i + 1);

            Console.Write("  Group name: ");
            string groupName = Console.ReadLine();

            Console.Write("  Starting date: ");
            string startDate = Console.ReadLine();

            Console.Write("  Number of attendees: ");
            int attendees = Convert.ToInt32(Console.ReadLine());

            conferences[i] = new Conference(groupName, startDate, attendees);
        }

        
        Array.Sort(conferences);

        Console.WriteLine("\nConferences sorted by attendance (smallest to largest):\n");
        Console.WriteLine("{0,-20} {1,-15} {2,10}", "Group Name", "Start Date", "Attendees");
        Console.WriteLine(new string('-', 47));

        foreach (Conference conf in conferences)
        {
            Console.WriteLine(conf);
        }
    }
}
