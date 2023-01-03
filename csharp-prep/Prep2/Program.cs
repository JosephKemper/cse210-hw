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
        if (userScore >= 90)
        {
            letterGrade = "A";
        }
        else if (userScore >= 80)
        {
            letterGrade = "B";
        }
        else if (userScore >= 70)
        {
            letterGrade = "C";
        }
        else if (userScore >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        Console.WriteLine($"You got a/an {letterGrade}");

    }
}