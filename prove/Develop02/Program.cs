using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        Menu mainMenu = new Menu ();
        mainMenu.DisplayMenu();
        mainMenu.GetUserChoice();

        // Need a loop to continue running until 5 is selected
        
    }
}