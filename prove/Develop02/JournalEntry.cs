using System;
// Class JournalEntry to establish data type for journal storage
public class JournalEntry
{
    // _journalPrompt member variable for storing the prompts for each journal entry
    public string _journalPrompt;
    // _journalText member variable for storing the text of each journal entry
    public string _journalText;
    // _currentDate member variable for storing the date each journal was written
    public string _currentDate;
    // DisplayEntry class method teaches computer how to display a single entry to user
    public void DisplayEntry()
    {
        Console.Write ("\b");
        Console.WriteLine ($"{_currentDate}");
        Console.WriteLine ($"{_journalPrompt}");
        Console.WriteLine (_journalText);
        Console.WriteLine();
        // Automatically pause after displaying each entry to allow the user a chance to read it
        Console.WriteLine ("Press any key to continue ...");
        Console.Write ("\b");
        Console.ReadKey();
    }
}