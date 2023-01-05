using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        // Write 5 functions

        // DisplayWelcome - Displays the message, 
        // "Welcome to the Program!"
        static void DisplayWelcome ()
        {
            Console.WriteLine ("Welcome to the Program!");
        }

        DisplayWelcome ();

        // PromptUserName - 
        // Asks for and returns the user's name (as a string)
        
        static string PromptUserName ()
        {
            Console.Write ("Please Enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }
        string userName = PromptUserName();

        // PromptUserNumber - 
        // Asks for and returns the user's favorite number (as an integer)
        static int PromptUserNumber ()
        {
            Console.Write ("Please enter your favorite number: ");
            string getUserNumber = Console.ReadLine();
            int userNumber=int.Parse(getUserNumber);
            return userNumber;
        }
        int userNumber = PromptUserNumber();
        // SquareNumber - 
        // Accepts an integer as a parameter 
        // and returns that number squared (as an integer)

        static int SquareNumber (int userNumber)
        {
            int numberSquared = userNumber * userNumber;
            return numberSquared;
        }

        int numberSquared = SquareNumber(userNumber);

        // DisplayResult - 
        // Accepts the user's name 
        // and the squared number and displays them.
        static void DisplayResult (int numberSquared, string userName)
        {
        Console.WriteLine ($"{userName}, the square of your number is {numberSquared}");
        }
        DisplayResult (numberSquared, userName);

    }
}