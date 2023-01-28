using System;
using System.IO;

public class Journal
{
    JournalPrompt newPrompt = new JournalPrompt ();
    List <JournalEntry> _completeJournal = new List <JournalEntry>();
    JournalEntry currentEntry = new JournalEntry();

    public void WriteJournal ()
    {
        currentEntry._currentDate = DateTime.UtcNow.ToString("dddd, dd MMMM, yyyy");
        
        currentEntry._journalPrompt = newPrompt.GeneratePrompt();
        Console.WriteLine (currentEntry._journalPrompt);

        currentEntry._journalText = Console.ReadLine();

        _completeJournal.Add (currentEntry);

    }

    public void DisplayJournal ()
    {
        foreach (JournalEntry entry in _completeJournal)
        {
            entry.DisplayEntry();
        }
    }

    public void SaveJournal()
    {
        Console.Write ("Please enter the file name: ");
        string fileName = Console.ReadLine();
        using (StreamWriter saveEntry = new StreamWriter (fileName))
        {
            foreach (JournalEntry entry in _completeJournal)
            {
                saveEntry.WriteLine ($"{entry._currentDate} , {entry._journalPrompt} , {entry._journalText}");
            }
        }
    }

    public void LoadJournal ()
    {
        Console.Write ("Enter the file name you wish to load: ");
        string fileName = Console.ReadLine ();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            string[] parts = line.Split (" , ");
            string entryDate = parts [0];
            string entryPrompt = parts [1];
            string entryText = parts [2];

            currentEntry._currentDate = entryDate;
            currentEntry._journalPrompt = entryPrompt;
            currentEntry._journalText = entryText;

            _completeJournal.Add(currentEntry);
        }
    }
}