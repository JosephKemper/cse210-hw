using System;

public class WriteJournalEntry
{
    public string Date ()
    {
        string currentDate = DateTime.UtcNow.ToString("dd-MMM-yyy");
        return currentDate;
    }
    
    public string JournalEntry (string date, string prompt)
    {
        Console.WriteLine(prompt);
        string currentEntry = Console.ReadLine();
        List <string> combinedEntry = new List<string>{
        date,
        prompt,
        currentEntry
        };
        return currentEntry;
    }

}