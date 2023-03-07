using System;

public class Menu
{
    private int _userChoice;
    private string _currentMenu;

    public void DisplayMainMenu()
    {
        Console.WriteLine ("Menu Options:");
        Console.WriteLine ("1. Create New Goal");
        Console.WriteLine ("2. List Goals");
        Console.WriteLine ("3. Save Goals");
        Console.WriteLine ("4. Load Goals");
        Console.WriteLine ("5. Record Event");
        Console.WriteLine ("6. Quit");
        Console.Write ("Select a choice from the menu: ");
    }

    public int GetUserInput ()
    {
        _userChoice = int.Parse(Console.ReadLine());
        return _userChoice;
    }
    public int GetUserChoice ()
    {
        return _userChoice;
    }

    public Menu ()
    {
        DisplayMainMenu ();
        GetUserInput ();
        Console.WriteLine ($"The choice was {_userChoice}");
    }
}