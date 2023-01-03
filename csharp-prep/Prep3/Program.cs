using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Console.Write("What is the magic number? ");
        string numberInput = Console.ReadLine();
        int magicNumber = int.Parse(numberInput);
        Console.WriteLine(magicNumber);


        Console.Write("What is your guess? ");
        string guessInput = Console.ReadLine();
        int numberGuess = int.Parse(guessInput);
        Console.WriteLine(numberGuess);
    }
}