using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");
        // Get user first name
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        // Get user last name
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        // Display name back to user in the following format
        // "Your name is (last name), (First name) (last name).
        Console.WriteLine ($"Your name is {lastName}, {firstName} {lastName}.")
    }
}
// Following git tutorial