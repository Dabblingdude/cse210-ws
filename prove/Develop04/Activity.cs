using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"{_name}\n{_description}\n");
        Console.Write("Enter the duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        PauseWithSpinner();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Good job!");
        PauseWithSpinner();
        Console.WriteLine($"You have completed {_name} for {_duration} seconds. ");
        PauseWithSpinner();
    }

    protected void PauseWithSpinner()
    {
        string[] spinner = { "|", "/", "-", "\\" };
        for (int i = 0; i < 8; i++)
        {
            Console.Write($"\r{spinner[i % 4]} ");
            Thread.Sleep(250);
        }
        Console.Write("\r");
    }

    protected void PauseWithCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\r{i}");
            Thread.Sleep(1000);
        }
        Console.Write("\r");
    }

    public abstract void Run();
}