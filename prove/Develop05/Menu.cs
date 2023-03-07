using System;

public class Menu
{
    private int _mainMenuChoice;
    private int _submenuChoice;

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

    public int SetMainMenuChoice ()
    {
        _mainMenuChoice = int.Parse(Console.ReadLine());
        return _mainMenuChoice;
    }
    public int GetMainMenuChoice ()
    {
        return _mainMenuChoice;
    }

    public int SetSubmenuChoice ()
    {
        _submenuChoice = int.Parse(Console.ReadLine());
        return _submenuChoice;
    }
    public int GetSubmenuChoice ()
    {
        return _submenuChoice;
    }

    public Menu ()
    {
        Console.WriteLine ();
        DisplayMainMenu ();
        SetMainMenuChoice ();

        if (_mainMenuChoice == 1)
        {
            Console.WriteLine();
            DisplayGoalsMenu ();
            SetSubmenuChoice ();
            if (_submenuChoice == 1)
            {
                // TODO #16 Bug Submenu no longer returning to main menu after selection.
                Console.WriteLine ("Create Simple Goal");
            }
            else if (_submenuChoice == 2)
            {
                Console.WriteLine ("Create Eternal Goal");
            }
            else if (_submenuChoice == 3)
            {
                Console.WriteLine ("Create Checklist Goal");
            }
        }
        else if (_mainMenuChoice == 2)
        {
            Console.WriteLine ("List Goals");
        }
        else if (_mainMenuChoice == 3)
        {
            Console.WriteLine ("Save Goals");
        }
        else if (_mainMenuChoice == 4)
        {
            Console.WriteLine ("LoadGoals");
        }
        else if (_mainMenuChoice == 5)
        {
            Console.WriteLine ("Record Event");
        }
        else if (_mainMenuChoice == 6)
        {
            Console.WriteLine ("Come Back Soon");
        }
        else 
        {
            Console.WriteLine ("Please enter the number of the menu option you wish to select.");
        }
    }
}