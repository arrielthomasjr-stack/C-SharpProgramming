using System;
using System.Collections;
/*Account numbers sometimes contain a check digit that is the result of a mathematical
calculation. The inclusion of the digit in an account number helps ascertain whether
the number is a valid one. Write an application named CheckDigit that asks a user
to enter a four-digit account number and determines whether it is a valid number.
The number is valid if the fourth digit is the remainder when the number represented
by the first three digits of the four-digit number is divided by 7. For example, 7770 is
valid, because 0 is the remainder when 777 is divided by 7.*/
class CheckDigit
{
    static void Main()
    {
        Console.Write("Enter four digit account number: ");
        int accountNumber = Convert.ToInt32(Console.ReadLine());

        int firstThreeDigits = accountNumber / 10; // Get the first three digits
        int checkDigit = accountNumber % 10; // Get the fourth digit

        if (checkDigit == (firstThreeDigits % 7))
        {
            Console.WriteLine("The account number is valid.");
        }
        else
        {
            Console.WriteLine("The account number is not valid.");
        }
    }
}
