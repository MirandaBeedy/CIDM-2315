﻿namespace Homework2Bonus;

class LeapYearCheck
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input a year:");
        int year = int.Parse(Console.ReadLine());

        if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
        {
            Console.WriteLine($"{year} is a leap year.");
        }

        else
        {
            Console.WriteLine($"{year} is not a leap year.");
        }

    }
}
