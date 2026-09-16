using System;
using System.Collections.Generic;
using System.Text;

class FotuneTeller
{
    static void DisplayFortune(string[] fortunes)
    {
        Random random = new Random();
        int index = random.Next(fortunes.Length);
        Console.WriteLine(fortunes[index]);
    }   
    static void Main(string[] args)
    {
        string[] fortunes = {
            "I see a tall, dark stranger in your future.",
            "You will have a great day today!",
            "Good things are coming your way.",
            "You will find happiness in unexpected places.",
            "Your hard work will pay off soon.",
            "A new opportunity is on the horizon."


        };
        DisplayFortune(fortunes);
    }
}
