using System;

class TestClassifiedAds
{
    static void Main()
    {
        ClassifiedAds HotWash = new ClassifiedAds();
        ClassifiedAds Krispy = new ClassifiedAds();
        HotWash.Category = "Carwash";
        HotWash.NumberOfWords = 20;
        Krispy.Category = "Food";
        Krispy.NumberOfWords = 30;

        Console.WriteLine("The cost is {0:F2}", HotWash.Price);
        Console.WriteLine("The cost is {0:F2}", Krispy.Price);
    }
}


