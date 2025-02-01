using System;
public class Entry
{
    public List<string> _currentEntry = new List<string>{}; // List for current entry being entered
    public void DisplayEntry(List<List<string>> listOfEntries) // receives list of entries and displays
    {
        foreach (var entry in listOfEntries) // repeats for every entry
        {
            Console.WriteLine
                ($"Date: {entry[2]}\nYour prompt was: {entry[0]}\nYou wrote: {entry[1]}\n");
        }
    } 
}