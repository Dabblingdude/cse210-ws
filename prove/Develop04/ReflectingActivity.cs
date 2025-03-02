using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for what you believe in.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you sacrificed for another.",
        "Think of a time when you served another and felt good afterwards."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience special to you?",
        "Have you ever done anything like this before?",
        "Would you like to do something like this again?",
        "How did you get started?",
        "How did you feel when it was complete?"
    };

    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on time when you have shown strength.", 0) {}

    public override void Run()
    {
        DisplayStartingMessage();
        Random rand = new Random();
        Console.WriteLine(_prompts[rand.Next(_prompts.Count)]);
        List<string> availableQuestions = new List<string>(_questions);
        PauseWithSpinner();
        PauseWithSpinner();
        PauseWithSpinner();
        int time = 0;
        while (time < _duration)
        {
            int questionIndex = rand.Next(availableQuestions.Count);
            string question = availableQuestions[questionIndex];
            Console.WriteLine(question);
            availableQuestions.RemoveAt(questionIndex);
            PauseWithSpinner();
            PauseWithSpinner();
            PauseWithSpinner();
            time += 5;
        }
        DisplayEndingMessage();
    }
}