using System;

class Program
{
    static void Main(string[] args)
    {
        GoalTracker tracker = new GoalTracker();
        UIManager uiManager = new UIManager(tracker);

        uiManager.ShowMenu();

        Console.WriteLine("Goodbye!");
    }
}