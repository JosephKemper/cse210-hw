using System;

public class Menu
{
    public void DisplayMenu()
    {

    Console.WriteLine ("1. Write");
    Console.WriteLine ("2. Display");
    Console.WriteLine ("3. Load");
    Console.WriteLine ("4. Save");
    Console.WriteLine ("5. Quit");
    }

    public string GetUserChoice ()
    {
        Console.Write ("What would you like to do? ");
        string userInput = Console.ReadLine();
        return userInput;
    }

// TODO #7 Write Journal Entry not loading
    public void LoadUserChoice (string userInput)
    {
        if (userInput == "1")
        {
            WriteJournalEntry write = new WriteJournalEntry ();
        }
    }
    // Method to take user choice and load appropriate class
}