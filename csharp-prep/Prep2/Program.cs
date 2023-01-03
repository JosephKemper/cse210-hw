using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        // Write a program to turn numbers into letter grade.

        // Get grade from user.
        Console.Write("Enter your percentage grade (leave off the % symbol): ");
        string userInput = Console.ReadLine();
        // Convert input to number format
        int userScore = int.Parse(userInput);
        string letterGrade;
        string preposition;
        string punctuation;
        if (userScore >= 90)
        {
            letterGrade = "A";
            preposition = "an";
            punctuation = "!";
        }
        else if (userScore >= 80)
        {
            letterGrade = "B";
            preposition = "a";
            punctuation = "!";
        }
        else if (userScore >= 70)
        {
            letterGrade = "C";
            preposition = "a";
            punctuation = "!";
        }
        else if (userScore >= 60)
        {
            letterGrade = "D";
            preposition = "a";
            punctuation = ".";
        }
        else
        {
            letterGrade = "F";
            preposition = "an";
            punctuation = ".";
        }

        string displayMessage;
        if (userScore >= 70)
        {
            displayMessage = "You Passed!";
        }
        else
        {
            displayMessage = "We're sorry, you didn't pass, but you'll do great next time.";
        }

        Console.WriteLine($"You got {preposition} {letterGrade}{punctuation}");
        Console.WriteLine(displayMessage);


    }
}