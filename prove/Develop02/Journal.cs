using System;
using System.Text.Json;

public class Journal
{
    // Saves the journal entries to a file
    public void SaveToFile(List<List<string>> entries, string fileName)
    {
        try
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(entries, options);
            File.WriteAllText(fileName, json);

            Console.WriteLine($"Entries successfully saved to file {fileName}.\n");
        }
        catch (Exception ex) // Explains error to user if one occurs
        {
            Console.WriteLine($"Error saving to file: {ex.Message}\nPlease try again with a different file name. Be sure to '.json' at the end\n");
        }
    }

    // Attempts to load entries from the filename given by the user
    public void LoadFromFile(ref List<List<string>> entries, string fileName)
    {
        try
        {
            // Clear current entries before loading new entries from the file
            entries.Clear();

            string json = File.ReadAllText(fileName);
            entries = JsonSerializer.Deserialize<List<List<string>>>(json);

            Console.WriteLine($"Entries are loaded from {fileName}.\n");
        }
        catch (Exception ex) // Explains error to user if one occurs
        {
            Console.WriteLine($"\nError loading from file: {ex.Message}\n");
        }
    }
}