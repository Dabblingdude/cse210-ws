using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by breathing in and out slowly.", 0) {}

    public override void Run()
    {
        DisplayStartingMessage();
        int actualDuration = _duration == 0 ? 5 : _duration;

        for (int i = 0; i < actualDuration / 6; i++)
        {
            Console.Clear();
            Console.WriteLine($"\rBreathe in...");
            AnimateBreathing("Breathe in", 3);  // Adjust this for the duration of the "Breathe in" phase
            PauseWithCountdown(3);  // Pause for 3 seconds
            
            // Breathe out animation
            Console.Clear();
            Console.WriteLine($"\rBreathe out...");
            AnimateBreathing("Breathe out", 3);  // Adjust this for the duration of the "Breathe out" phase
            PauseWithCountdown(3);  // Pause for 3 seconds
        }
        DisplayEndingMessage();
    }

    private void AnimateBreathing(string message, int duration)
    {
        for (int i = 0; i < duration; i++)
        {
            Console.Clear();
            string expandedMessage = message.PadLeft(message.Length + i).PadRight(40);
            Console.WriteLine(expandedMessage);
            Thread.Sleep(500);
        }

        for (int i = duration; i < 0; i--)
        {
            Console.Clear();
            string contractedMessage = message.PadRight(message.Length + i).PadLeft(40);
            Console.WriteLine(contractedMessage);
            Thread.Sleep(500);
        }
    }
}