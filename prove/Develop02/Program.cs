using System;
using System.Data;
// ----------------------
// EXCEEDING REQUIREMENTS: 
// Changed file format for saving to JSON
// Added various error handling
// Polished terminal to be more readable and clear
// ----------------------

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the premier program in helping you journal!");

        string command = "0"; // number to specify what the program should do
        List<List<string>> currentFileEntries = new List<List<string>>{}; // List of list of strings. To hold multiple entries for displaying, saving, and loading
        Journal journal1 = new Journal(); // Create a new Journal instance

        while (command != "5")
        {
            Console.WriteLine("Please select one of the following options:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display entries");
            Console.WriteLine("3. Load file");
            Console.WriteLine("4. Save file");
            Console.WriteLine("5. Quit");
            Console.Write("Please enter your choice: ");
            command = Console.ReadLine(); // Records instruction input
            Console.WriteLine("");

            if (command == "1") // Write a new entry
            {
                Prompts newPrompt = new Prompts();
                Entry entry1 = new Entry(); // Creates list for current entry, prompt, and date

                entry1._currentEntry.Add(newPrompt.DisplayRandomPrompt()); // Gets new prompt, shows it, and adds it to the entry list
                entry1._currentEntry.Add(Console.ReadLine()); // Adds response to current entry list
                DateTime theCurrentTime = DateTime.Now;
                entry1._currentEntry.Add(theCurrentTime.ToShortDateString()); // Adds date to current entry list
                
                currentFileEntries.Add(entry1._currentEntry); // Adds current entry to list of entries
                Console.WriteLine("Entry Recorded!\n");
            }

            else if (command == "2") // Displays current file/session
            {
                Entry entry1 = new Entry();
                entry1.DisplayEntry(currentFileEntries); // Calls on Entry class to display all current entries
            }

            else if (command == "3") // Loads file
            {
                Console.Write("Enter the filename to load: ");
                string fileName = Console.ReadLine();
                journal1.LoadFromFile(ref currentFileEntries, fileName); // Load entries into currentFileEntries
            }

            else if (command == "4") // Saves file
            {
                Console.Write("Enter the filename to save to: ");
                string fileName = Console.ReadLine();
                journal1.SaveToFile(currentFileEntries, fileName); // Save currentFileEntries to the specified file
            }

            else if (command == "5") // Quits Program
            {
                Console.WriteLine("Thank you for journaling today. Goodbye!"); // Goodbye :)
            }

            else // Invalid input handling
            {
                Console.WriteLine("\nInvalid input. Please enter a number from 1-5\n");           
            }
        }
    }
}