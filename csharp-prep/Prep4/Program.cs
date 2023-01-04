using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        List<int> userNumberList = new List<int>();
        int userNumber;

        Console.WriteLine ("Enter a list of numbers, type 0 when finished.");

        // Create a loop to collect numbers from user
        do
        {
        Console.Write ("Enter number: ");
        string userInput = Console.ReadLine();

        // Convert user input to number
        userNumber = int.Parse(userInput);

        // Add numbers to list
        userNumberList.Add(userNumber);
        }while (userNumber != 0);

        // Loop should continue until user enters 0

        // Sum numbers in list

        // Count the number of items in the list

        // Calculate average of numbers in list

        // Find largest number in list
    }
}