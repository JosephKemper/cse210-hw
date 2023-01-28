using System;

public class Journal : JournalPrompt
{
    JournalPrompt newPrompt = new JournalPrompt ();
    List <JournalEntry> _completeJournal = new List<JournalEntry>();
    
    public void WriteJournal ()
    {
        JournalEntry currentEntry = new JournalEntry();

        string _currentDate = DateTime.UtcNow.ToString("dd-MMM-yyy");
        
        int _promptIndex = newPrompt.GenerateIndex();
        string _journalPrompt = newPrompt.GeneratePrompt(_promptIndex);
        
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