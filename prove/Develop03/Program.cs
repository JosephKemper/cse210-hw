using System;
namespace Develop03;

class Program
{
    static void Main(string[] args)
    {
        Reference currentReference = new Reference();
        Scripture currentScripture = new Scripture();
        Menu mainMenu = new Menu();
        currentScripture.LoadScriptures();
        currentReference.LoadScriptures();
        mainMenu.LoadScriptures();
        
        string reference = currentScripture.DisplayReference();
        string verse = currentScripture.DisplayVerse();

        Console.WriteLine ("Welcome to the Scripture Memorizer App");

        string userInput = "";
        while (userInput != "3"){
            mainMenu.MainMenu();
            
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