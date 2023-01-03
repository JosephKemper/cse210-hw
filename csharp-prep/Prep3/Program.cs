using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Console.Write("What is the magic number? ");
        string numberInput = Console.ReadLine();
        int magicNumber = int.Parse(numberInput);

        Console.Write("What is your guess? ");
        string guessInput = Console.ReadLine();
        int numberGuess = int.Parse(guessInput);
        
        if (numberGuess > magicNumber)
        {
            Console.WriteLine ("Lower");
        }
        else if (numberGuess < magicNumber)
        {
            Console.WriteLine ("Higher");
        }
        else
        {
            Console.WriteLine ("You Guessed it!");
        }

    }
}