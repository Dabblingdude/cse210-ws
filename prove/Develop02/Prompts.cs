using System;
public class Prompts
{
    Random _rand = new Random(); 

    // Creates a list of possible prompts to send to the user
    public List<string> _randomPrompts = new List<string> 
    { 
        "What questions did you ask today?"
        , "What are you proud of yourself for for today?"
        , "What made you smile today?"
        , "Is there someone special to you that you haven't talked to in a while?"
        , "What is weighing down on you today?"
        , "What did I do to serve another today?"
        , "What was something unexpected that happened today?"
    };

    // Displays one of the prompts at random and returns it the main for saving
    public string DisplayRandomPrompt() 
    {
        string currentPrompt = _randomPrompts[_rand.Next(0,5)];
        Console.WriteLine(currentPrompt);
        return currentPrompt;
    }
}