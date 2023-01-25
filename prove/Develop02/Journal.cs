using System;

public class Journal : JournalPrompt
{
    public string Date ()
    {
        string currentDate = DateTime.UtcNow.ToString("dd-MMM-yyy");
        return currentDate;
    }
    JournalPrompt newPrompt = new JournalPrompt ();
    
    public string JournalEntry (string date)
    {
        int promptIndex = newPrompt.GenerateIndex();
        string prompt = newPrompt.GeneratePrompt(promptIndex);
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