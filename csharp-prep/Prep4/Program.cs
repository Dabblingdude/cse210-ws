using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a series of numbers. Enter '0' when you would like to stop.");

        List<int> numbers = new List<int>();
        int newNum = 1;

        while (newNum != 0)
        {
        newNum = int.Parse(Console.ReadLine());

        if (newNum != 0)
        {
            numbers.Add(newNum);
        }
        }

        Console.WriteLine($"The sum is: {numbers.Sum()}");
        Console.WriteLine($"The average is: {numbers.Average()}");
        Console.WriteLine($"The largest number is: {numbers.Max()}");

    }
}