using System;

// This was copied from code that I made on my laptop while I was out of town. I was unsuccessful in connecting it to my github on it, so I had to wait and then copied and pasted it here on my desktop to get it to work.
// 
// This program exceeds the requirements by:
// 1. Incrementally hiding more words with each press of Enter. This is more useful because there is such a large scripture verse and it gives the user more control.
// 2. Added a scripture library that is expandable. It randomly selects a verse on each run of the program.





public class Program
{
    static void Main(string[] args)
    {
        // Create a library of scriptures
        List<Scripture> scriptureLibrary = new List<Scripture>
        {
            new Scripture(new Reference("Doctrine & Covenants", 132, 19), "And again, verily I say unto you, if a man marry a wife by my word, which is my law, and by the new and everlasting covenant, and it is sealed unto them by the Holy Spirit of promise, by him who is anointed, unto whom I have appointed this power and the keys of this priesthood; and it shall be said unto them—Ye shall come forth in the first resurrection; and if it be after the first resurrection, in the next resurrection; and shall inherit thrones, kingdoms, principalities, and powers, dominions, all heights and depths—then shall it be written in the Lamb’s Book of Life, that he shall commit no murder whereby to shed innocent blood, and if ye abide in my covenant, and commit no murder whereby to shed innocent blood, it shall be done unto them in all things whatsoever my servant hath put upon them, in time, and through all eternity; and shall be of full force when they are out of the world; and they shall pass by the angels, and the gods, which are set there, to their exaltation and glory in all things, as hath been sealed upon their heads, which glory shall be a fulness and a continuation of the seeds forever and ever."),
            new Scripture(new Reference("Jacob", 6, 12), "O be wise; what can I say more?"),
            new Scripture(new Reference("John", 11, 35), "Jesus wept."),
            // Add more scriptures as needed
        };

        Random random = new Random();
        Scripture selectedScripture = scriptureLibrary[random.Next(scriptureLibrary.Count)];

        int wordsHiddenIncrement = 1;  // Default: Hide one word at a time

        while (true)
        {
            Console.Clear();
            selectedScripture.Display();
            Console.WriteLine("\nPress Enter to hide a few words, or type a number to hide that many words.");
            Console.WriteLine("Type 'quit' to exit.");

            string input = Console.ReadLine()?.Trim().ToLower();

            if (input == "quit")
                break;

            if (int.TryParse(input, out int wordsToHide))
            {
                // If user enters a number, set the words to hide to that number
                wordsHiddenIncrement = wordsToHide;
            }
            else if (string.IsNullOrWhiteSpace(input))
            {
                // If Enter is pressed without input, increment words to hide by 1
                wordsHiddenIncrement++;
            }

            // Hide words (incrementally or based on user input)
            if (!selectedScripture.HideRandomWords(wordsHiddenIncrement) || selectedScripture.AllWordsHidden())
            {
                selectedScripture.Display();
                Console.WriteLine("\nAll words are hidden. Press Enter to exit.");
                Console.ReadLine();
                break;
            }
        }
    }
}