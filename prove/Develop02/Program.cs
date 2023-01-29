using System;

class Program
{
    static void Main(string[] args)
    {
        // initialize userJournal as Journal instance
        Journal userJournal = new Journal();
        // Declare _userChoice member variable to store user choice for menu loop
        string _userChoice = "";

        Console.WriteLine ("Welcome to the Journal Program!");
    
        // Display menu options to user
        while (_userChoice != "5") {
            Console.WriteLine ("Please select one of the following choices:");
            Console.WriteLine ("1. Write");
            Console.WriteLine ("2. Display");
            Console.WriteLine ("3. Load");
            Console.WriteLine ("4. Save");
            Console.WriteLine ("5. Quit");
            Console.Write ("What would you like to do? ");

            // Get _userChoice from user 
            _userChoice = Console.ReadLine();

            // Compare _userChoice to different options and load appropriate userJournal method
            if (_userChoice == "1"){
                // Write journal entry
            userJournal.WriteJournal();
                
            }else if (_userChoice == "2"){
                // Display journals typed
                userJournal.DisplayJournal();

            }else if (_userChoice == "3"){
                // Load journals from file
                userJournal.LoadJournal();

            }else if (_userChoice == "4"){
                // Save journals to file
                userJournal.SaveJournal();

            }else if (_userChoice == "5"){
                // Exit program
                Console.WriteLine ("Thank you for using our Journal Program!");
                Console.WriteLine ("Come back soon.");
                Environment.Exit(0);
            }else {
                // Catch incorrect entries to prevent app crashing
                Console.WriteLine ("Please enter the number of the option you wish to select.");
            }
        }

    }
}