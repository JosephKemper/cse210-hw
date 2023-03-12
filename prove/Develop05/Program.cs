using System;

class Program
{
    static void Main(string[] args)
    {
        SimpleGoal simpleGoal = new SimpleGoal();
        Goal goalManager = new Goal ();

       int _MenuChoice=0;
       int _submenuChoice=0;

        Console.WriteLine ("Welcome to the Goal Tracker");

        while (_MenuChoice != 6){
            Console.WriteLine ("Menu Options:");
            Console.WriteLine ("1. Create New Goal");
            Console.WriteLine ("2. List Goals");
            Console.WriteLine ("3. Save Goals");
            Console.WriteLine ("4. Load Goals");
            Console.WriteLine ("5. Record Event");
            Console.WriteLine ("6. Quit");
            Console.Write ("Select a choice from the menu: ");

            _MenuChoice = int.Parse (Console.ReadLine ());
            
            if (_MenuChoice == 1){
                Console.WriteLine();
                Console.WriteLine ("Types of Goals are:");
                Console.WriteLine ("1. Simple Goal");
                Console.WriteLine ("2. Eternal Goal");
                Console.WriteLine ("3. Checklist Goal");
                Console.Write ("Which type of goal would you like to create? ");

                _submenuChoice = int.Parse (Console.ReadLine ());

                if (_submenuChoice == 1){
                    simpleGoal.CreateGoal();
                    }
                else if (_submenuChoice == 2){
                    Console.WriteLine ("Create Eternal Goal");
                    }
                else if (_submenuChoice == 3){
                    Console.WriteLine ("Create Checklist Goal");
                    }
                }
                else if (_MenuChoice == 2){
                    goalManager.ListGoals();
                    }
            else if (_MenuChoice == 3){
                Console.WriteLine ("Save Goals");
                }
            else if (_MenuChoice == 4){
                Console.WriteLine ("LoadGoals");
                }
            else if (_MenuChoice == 5){
                Console.WriteLine ("Record Event");
                }
            else if (_MenuChoice == 6){
                Console.WriteLine ("Come Back Soon");
                }
            else{
                Console.WriteLine ("Please enter the number of the menu option you wish to select.");
                }
        }
    }
}