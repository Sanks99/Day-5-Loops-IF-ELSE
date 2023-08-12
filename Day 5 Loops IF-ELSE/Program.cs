using System;

class Program
{
    static void Main()
    {
        // Check if User is 20+
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        if (age >= 20)
        {
            Console.WriteLine("You are 20 years or older.");
        }
        else
        {
            Console.WriteLine("You are younger than 20.");
        }
        Console.WriteLine();

        // Check if a Number is Positive, Negative, or Zero
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (number > 0)
        {
            Console.WriteLine($"{number} is positive.");
        }
        else if (number < 0)
        {
            Console.WriteLine($"{number} is negative.");
        }
        else
        {
            Console.WriteLine($"{number} is zero.");
        }
        Console.WriteLine();

        // Check if a Year is a Leap Year
        Console.Write("Enter a year: ");
        int year = int.Parse(Console.ReadLine());

        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            Console.WriteLine($"{year} is a leap year.");
        }
        else
        {
            Console.WriteLine($"{year} is not a leap year.");
        }

        Console.ReadLine();
    }
}