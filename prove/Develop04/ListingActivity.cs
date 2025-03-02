using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate in your life?",
        "What is an undeniable personal strengths of yours?",
        "Who can you help tomorrow?",
        "How have you been blessed and guided by the Lord?"
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the positive things in your life.", 0) {}

    public override void Run()
    {
        DisplayStartingMessage();
        Random rand = new Random();
        Console.WriteLine(_prompts[rand.Next(_prompts.Count)]);
        PauseWithCountdown(3);
        Console.WriteLine("Start listing...");
        List<string> responses = new List<string>();
        int time = 0;
        while (time < _duration)
        {
            responses.Add(Console.ReadLine());
            time += 3;
        }
        Console.WriteLine($"You listed {responses.Count} items.");
        DisplayEndingMessage();
    }
}