//Prompt for and read monthly income
Console.Write("Enter monthly income: ");
string incomeInput = Console.ReadLine();

//Convert income safely with TryParse
if (!decimal.TryParse(incomeInput, out decimal income))
{
    Console.WriteLine("That wasn't a valid number. Please run the program again.");
    return;
}   

//Prompt for and read rent
Console.Write("Enter your monthly rent: ");
string rentInput = Console.ReadLine();

//Convert rent safely with TryParse
if (!decimal.TryParse(rentInput, out decimal rent))
{
    Console.WriteLine("That wasn't a valid number.");
    return;
}

//Prompt for and read number of subscriptions
Console.Write("Number of Subscriptions: ");
string subInput = Console.ReadLine();

//Convert number of subscriptions safely with TryParse
if (!int.TryParse(subInput, out int subscriptionCount))
{
    Console.WriteLine("That wasn't a valid whole number.");
    return;
}

//Calculate remaining income
decimal subscriptionCost = subscriptionCount * 9.99m;
decimal remaining = income - rent - subscriptionCost;

//Display a formatted summary
Console.WriteLine();
Console.WriteLine("----- Monthly Summary -----");
Console.WriteLine($"Income:              {income:C}");
Console.WriteLine($"Rent:                {rent:C}");
Console.WriteLine($"Subscriptions:    ({subscriptionCount}):   {subscriptionCost:C}");
Console.WriteLine($"Remaining Income:    {remaining:C}");