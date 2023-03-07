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
    public void DisplayGoalsMenu ()
    {
        Console.WriteLine ("Types of Goals are:");
        Console.WriteLine ("1. Simple Goal");
        Console.WriteLine ("2. Eternal Goal");
        Console.WriteLine ("3. Checklist Goal");
        Console.Write ("Which type of goal would you like to create? ");
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
        Console.WriteLine ();
        DisplayMainMenu ();
        GetUserInput ();

        if (_userChoice == 1)
        {
            Console.WriteLine();
            DisplayGoalsMenu ();
            GetUserInput ();
            if (_userChoice == 1)
            {
                Console.WriteLine ("Create Simple Goal");
            }
            else if (_userChoice == 2)
            {
                Console.WriteLine ("Create Eternal Goal");
            }
            else if (_userChoice == 3)
            {
                Console.WriteLine ("Create Checklist Goal");
            }
        }
        else if (_userChoice == 2)
        {
            Console.WriteLine ("List Goals");
        }
        else if (_userChoice == 3)
        {
            Console.WriteLine ("Save Goals");
        }
        else if (_userChoice == 4)
        {
            Console.WriteLine ("LoadGoals");
        }
        else if (_userChoice == 5)
        {
            Console.WriteLine ("Record Event");
        }
        else if (_userChoice == 6)
        {
            Console.WriteLine ("Come Back Soon");
        }
        else 
        {
            Console.WriteLine ("Please enter the number of the menu option you wish to select.");
        }
    }
}