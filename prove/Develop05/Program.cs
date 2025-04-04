using System;

// To Exceed requirements, I added an experience and leveling up system.
// XP is accumulated by making progress on goals and levels up file user
// when passing set thresholds.
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