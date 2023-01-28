using System;

public class Journal : JournalPrompt
{
    JournalPrompt newPrompt = new JournalPrompt ();
    List <List<string>> _completeJournal = new List <List<string>>();
    
    public void JournalEntry (string _date)
    {
        int _promptIndex = newPrompt.GenerateIndex();
        string _prompt = newPrompt.GeneratePrompt(_promptIndex);
        Console.WriteLine(_prompt);
        string _currentEntry = Console.ReadLine();
        List <string> _combinedEntry = new List<string>{
        _date,
        _prompt,
        _currentEntry
        };
        _completeJournal.Add(_combinedEntry);
    }
}