using System;

public class JournalEntry
{
    public string _journalPrompt;
    public string _journalText;
    public string _currentDate;
    public void DisplayEntry()
    {
        Console.WriteLine ($"Date: {_currentDate}");
        Console.WriteLine ($"Prompt {_journalPrompt}");
        Console.WriteLine (_journalText);
        Console.WriteLine();
        Console.WriteLine ("Press any key to continue ...");
        Console.WriteLine();
        Console.ReadKey();
    }
}