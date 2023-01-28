using System;

class Program
{
    Journal journal = new Journal();
    static void Main(string[] args)
    {
        Console.WriteLine ("Welcome to the Journal Program!");
        Console.WriteLine ("Please select one of the following choices:");
        Console.WriteLine ("1. Write");
        Console.WriteLine ("2. Display");
        Console.WriteLine ("3. Load");
        Console.WriteLine ("4. Save");
        Console.WriteLine ("5. Quit");
        Console.Write ("What would you like to do? ");

        string userChoice = Console.ReadLine();

        if (userChoice == "1"){
            // Write journal entry
        }else if (userChoice == "2"){
            // Display journals typed
        }else if (userChoice == "3"){
            // Load journals from file
        }else if (userChoice == "4"){
            // Save journals to file
        }else if (userChoice == "5"){
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