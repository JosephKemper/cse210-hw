using System;


class Program
{
    static void Main(string[] args)
    {
        /*
        Purpose: 
        Display a scripture that will slowly disappear for the user to memorize. 
        Inputs: The enter key and typing the word quit
        Outputs: 
        Initially a complete scripture, 
        but as they hit enter, 
        the words from the scripture will slowly disappear
        */
        string _userInput ="";
        Console.WriteLine ("Welcome to the Scripture Memorizer App");
        Scripture newScripture = new Scripture();
        newScripture.LoadScriptures();
        newScripture.SelectScripture();
        while (_userInput != "quit")
        {
            newScripture.DisplayScripture();
            Console.WriteLine ();
            Console.WriteLine ("Press Enter to continue or type 'quit' to exit.");
            _userInput = Console.ReadLine ();
        }
    }
}
