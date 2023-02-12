using System;
namespace Develop03;

class Program
{
    static void Main(string[] args)
    {
        
        Scripture currentScripture = new Scripture();


        string reference = currentScripture.DisplayReference();
        string verse = currentScripture.DisplayVerse();

        Console.WriteLine ("Welcome to the Scripture Memorizer App");

        string userInput = "";
        while (userInput != "3"){
            Console.WriteLine ();
            Console.WriteLine ("1. Choose a scripture to memorize");
            Console.WriteLine ("2. Memorize a random scripture");
            Console.WriteLine ();
            Console.Write ("Please enter your selection or type 'quit' to exit: ");
            
            userInput = Console.ReadLine ();
            

            if (userInput == "1"){
                mainMenu.ScriptureSelection();
            }else if (userInput == "2"){
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            }else if (userInput == "3"){
            Environment.Exit(3);
            }else {
            Console.WriteLine ("Please enter the number of the option you wish to select.");
            }

            
            
            
        }
    }
}