using System;
namespace Develop03;

class Program
{
    static void Main(string[] args)
    {
        Scripture currentScripture = new Scripture();
        string reference = currentScripture.DisplayReference();
        string verse = currentScripture.DisplayVerse();



        string userInput = "";
        while (userInput != "quit"){
        Console.Clear();
        Console.WriteLine ($"{reference} {verse}");
        Console.WriteLine();

        Console.WriteLine("Press enter to continue or type 'quit' to finish:");
        
        userInput = Console.ReadLine ();
        }
    }
}