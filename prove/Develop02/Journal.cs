using System;

public class Journal : JournalPrompt
{
    JournalPrompt newPrompt = new JournalPrompt ();
    List <List<JournalEntry>> _completeJournal = new <List<JournalEntry>>();
    
    public void WriteJournal ()
    {
        JournalEntry currentEntry = new JournalEntry();


        currentEntry._currentDate = DateTime.UtcNow.ToString("dddd, dd MMMM, yyyy");
        
        string _journalPrompt = newPrompt.GeneratePrompt();
        
        
        Console.WriteLine(_journalPrompt);
        string _currentEntry = Console.ReadLine();
        List <string> _combinedEntry = new List<string>{
        _currentDate,
        _journalPrompt,
        _currentEntry
        };
        _completeJournal.Add(_combinedEntry);
    }
}