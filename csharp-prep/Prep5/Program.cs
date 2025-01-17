using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.WriteLine("Please enter your name: ");
            return Console.ReadLine();
        }

        static int PromptUserNumber()
        {
            Console.WriteLine("Please enter your favorite number: ");
            
            return int.Parse(Console.ReadLine());
        }

        static int SquareNumber(int num)
        {
            return num*num;
        }

        static void DisplayResult(string userName, int sqr)
        {
            Console.WriteLine($"{userName}, the square of your number is {sqr}");
        }

        DisplayWelcome();
        string name = PromptUserName();
        int num = PromptUserNumber();
        int sqr = SquareNumber(num);
        DisplayResult(name, sqr);
    }
}