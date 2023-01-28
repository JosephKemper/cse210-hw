using System;

public class Journal
{
    JournalPrompt newPrompt = new JournalPrompt ();
    List <JournalEntry> _completeJournal = new List <JournalEntry>();
    
    public void WriteJournal ()
    {
        JournalEntry currentEntry = new JournalEntry();


        currentEntry._currentDate = DateTime.UtcNow.ToString("dddd, dd MMMM, yyyy");
        
        currentEntry._journalPrompt = newPrompt.GeneratePrompt();
        Console.WriteLine (currentEntry._journalPrompt);

        currentEntry._entryText = Console.ReadLine();

        _completeJournal.Add (currentEntry);

    }

    public void DisplayJournal ()
    {
        foreach (JournalEntry entry in _completeJournal)
        {
            entry.DisplayEntry();
        }
    }
}