using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

class Menu
{
    public void ShowMenu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Select an activity: ");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    new BreathingActivity().Run();
                    break;
                case "2":
                    new ReflectingActivity().Run();
                    break;
                case "3":
                    new ListingActivity().Run();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid selection. Please enter a 1-4.");
                    Thread.Sleep(1000);
                    break;
            }
        }
    }
}