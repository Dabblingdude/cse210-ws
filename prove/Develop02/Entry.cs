using System;
public class Entry
{
    public List<string> _currentEntry = new List<string>{}; // List for current entry being entered
    public void DisplayEntry(List<List<string>> listOfEntries) // receives list of entries and displays
    {
        foreach (var entry in listOfEntries) // repeats for every entry
        {
            Console.WriteLine($"Date: {entry[2]}");
            Console.WriteLine($"Your prompt was: {entry[0]}");
            Console.WriteLine($"You wrote: {entry[1]}");
            Console.WriteLine("");
        }
    } 
}