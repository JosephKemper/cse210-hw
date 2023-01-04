using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        // playAgain variable set to "y" to get while loop to run first time
        string playAgain = "y";
        while (playAgain == "y")
        { 
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,100);
        Console.WriteLine("I'm choosing a number between 1 and 100 inclusive.");
        
        int numberGuess;
        // Initiate user guess tracking
        int guessTracker = 0;

        do
        {
        // Get guess from user
        Console.Write("What is your guess? ");
        string guessInput = Console.ReadLine();
        numberGuess = int.Parse(guessInput);
        
        // Increase number of user guesses.
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
            // Display end of game text.
            Console.WriteLine ("You Guessed it!");
            Console.WriteLine ($"It took you {guessTracker} guesses.");
        }

        } while (numberGuess != magicNumber);
        Console.Write ("Do you want to play again (y/n)");
        playAgain = Console.ReadLine();
        }
        Console.WriteLine ("Thanks for playing!");
        
    }
}