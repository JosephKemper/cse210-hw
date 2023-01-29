using System;
using System.IO;

public class Journal
{
    // _completeJournal member variable for storing a list of the complete user journal
    List <JournalEntry> _completeJournal = new List <JournalEntry>();
    
    // WriteJournal class method teaches computer how to let the user write a journal entry
    public void WriteJournal ()
    {
        // Call JournalPrompt class to generate prompt for current journal entry
        JournalPrompt newPrompt = new JournalPrompt ();
        // Call JournalEntry class to enable storage of journal entry parts
        JournalEntry currentEntry = new JournalEntry();

        // Use currentEntry class instance to collect and format _currentDate as string
        currentEntry._currentDate = DateTime.UtcNow.ToString("dddd, dd MMMM, yyyy");
        
        // Use currentEntry class instance to collect randomly generated _journalPrompt
        currentEntry._journalPrompt = newPrompt.GeneratePrompt();
        // Display _journalPrompt to user
        Console.WriteLine (currentEntry._journalPrompt);

        // Use currentEntry class method to collect journal text from user
        currentEntry._journalText = Console.ReadLine();

        // add currentEntry data to _completeJournal list
        _completeJournal.Add (currentEntry);
    }

    // DisplayJournal method uses DisplayEntry method to teach computer how to display complete journal
    public void DisplayJournal ()
    {
        // Loop through each entry in the journal
        foreach (JournalEntry entry in _completeJournal)
        {
            // use DisplayEntry method from Journal Entry class to display journal entry
            entry.DisplayEntry();
        }
    }

    // SaveJournal class method teaches computer how to save journal entry to file
    public void SaveJournal()
    {
        // Get file name from user to save journal to
        Console.Write ("Please enter the file name: ");
        string fileName = Console.ReadLine();

        // use StreamWriter method to loop through journal and write each entry to file
        using (StreamWriter saveEntry = new StreamWriter (fileName))
        {
            foreach (JournalEntry entry in _completeJournal)
            {
                // use JournalEntry class to teach computer where to put each part of the journal
                saveEntry.WriteLine ($"{entry._currentDate} , {entry._journalPrompt} , {entry._journalText}");
            }
        }
    }

    public void LoadJournal ()
    // BUG #10 When loading the journal, and then trying to display it, replaces all entries with the first
    {
        Console.Write ("Enter the file name you wish to load: ");
        string fileName = Console.ReadLine ();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            JournalEntry loadEntry = new JournalEntry();
            string[] parts = line.Split (" , ");
            string entryDate = parts [0];
            string entryPrompt = parts [1];
            string entryText = parts [2];

            loadEntry._currentDate = entryDate;
            loadEntry._journalPrompt = entryPrompt;
            loadEntry._journalText = entryText;

            _completeJournal.Add(loadEntry);
        }
    }
}