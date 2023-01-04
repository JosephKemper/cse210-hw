using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        // Get number from user
        Console.Write("What is the magic number? ");
        string numberInput = Console.ReadLine();
        int magicNumber = int.Parse(numberInput);
        int numberGuess;
        int guessTracker = 0;

        do
        {
        // Get guess from user
        Console.Write("What is your guess? ");
        string guessInput = Console.ReadLine();
        numberGuess = int.Parse(guessInput);
        
        guessTracker ++;

        // Check if guess is greater than number and return message
        if (numberGuess > magicNumber)
        {
            Console.WriteLine ("Lower");
        }
        // Check if guess is less than number and return message
        else if (numberGuess < magicNumber)
        {
            Console.WriteLine ("Higher");
        }
        // Return Equals message
        else
        {
            Console.WriteLine ("You Guessed it!");
            Console.WriteLine ($"It took you {guessTracker} guesses.");
        }

        } while (numberGuess != magicNumber);

    }
}