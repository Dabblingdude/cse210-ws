using System;

class Program
{
    static void Main(string[] args)
    {
        Random magnum = new Random();
        int magNum = magnum.Next(1, 100);

        Console.WriteLine("There is a magic number between 1 and 100");

        bool guess = false;
        int count = 1;

        while (guess == false)
        {
        Console.WriteLine("Please enter your guess for the magic number: ");
        string input = Console.ReadLine();
        int num = int.Parse(input);

        if (num > magNum)
        {
            Console.WriteLine("Lower");
            count += 1;
        }
        else if (num < magNum)
        {
            Console.WriteLine("Higher");
            count += 1;
        }
        else
        {
            Console.WriteLine("You guessed the number!");
            Console.WriteLine($"It took you {count} guesses");
            guess = true;
        }
        }
    }
}