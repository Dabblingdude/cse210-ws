using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;


    // Constructor for the Scripture class
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
        _random = new Random();
    }


    // Method to hide random words in the scripture
    public bool HideRandomWords(int count)
    {
        var visibleWords = _words.Where(word => !word.IsHidden()).ToList();

        if (visibleWords.Count == 0)
        {
            return false;
        }

        // Hide up to the specified count of random words
        int wordsToHide = Math.Min(count, visibleWords.Count);

        for (int i = 0; i < wordsToHide; i++)
        {
            int index = _random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }

        return true;
    }


    // Method to display the scripture, clearing the console each time
    public void Display()
    {
        Console.Clear();
        Console.WriteLine("\n" + _reference);
        Console.WriteLine(string.Join(" ", _words));
    }


    // Check if all words are hidden
    public bool AllWordsHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}