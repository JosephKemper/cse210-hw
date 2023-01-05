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

        // Check if number is 0
        if (userNumber == 0)
        {
            Console.WriteLine("Here is your Highlights");
        }
        else
        {
        // Add numbers to list
        userNumberList.Add(userNumber);
        }
        // Loop should continue until user enters 0
        }while (userNumber != 0);

        int sumList = 0;

        // Find largest number in list
        int largestNumber = userNumberList.Max();

        // Set largestNumber to findSmallestNumber
        int findSmallestPositive = largestNumber;

        // Sum numbers in list
        foreach (int number in userNumberList)
        {
            sumList += number;
        // If positive, check if less than findSmallestNumber
        if (number >0)
        {
            if (number < findSmallestPositive)
            {
                findSmallestPositive = number;
            }
            // If negative, ignore
        }

        


        }
        // Count the number of items in the list
        int listLength = userNumberList.Count;
        Console.WriteLine ($"You entered {listLength} numbers.");

        Console.WriteLine ($"The sum is: {sumList}");

        // Calculate average of numbers in list
        float listAverage = sumList/listLength;
        Console.WriteLine ($"The average is: {listAverage}");

        Console.WriteLine ($"The largest number is: {largestNumber}");

        // Display smallest number to user
        Console.WriteLine ($"The smallest positive number is: {findSmallestPositive}");

        // Sort userNumberList
        // Sorted list method found on https://zetcode.com/csharp/sortlist/
        var sortList = from number in userNumberList
                        orderby number descending
                        select number;

        // Iterate through list
        Console.WriteLine("The Sorted list is:");
        foreach (var e in sortList)
        {
            // Print individual numbers to console
            Console.WriteLine(e);
        }

        

        

    }
}