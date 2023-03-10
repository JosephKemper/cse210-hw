using System;
using System.IO;

namespace Develop04
{
    class Program
    {
        static void Main(string[] args)
        {
            string _userSelection = "";
            Console.WriteLine("Welcome to the Mindfulness Program");
            while (_userSelection != "4")
            {
                Console.WriteLine("Menu Options");
                Console.WriteLine("1. Start Breathing Activity");
                Console.WriteLine("2. Start Reflecting Activity");
                Console.WriteLine("3. Start Listing Activity");
                Console.WriteLine("4. Quit");
                Console.Write("Select a choice from the menu: ");
                
                _userSelection = Console.ReadLine();
                Console.WriteLine();

                if (_userSelection == "1")
                {
                    BreathingActivity runBreathingActivity = new BreathingActivity();
                }
                else if (_userSelection == "2")
                {
                    ReflectionActivity runReflectingActivity = new ReflectionActivity();
                    Console.WriteLine (runReflectingActivity.choosePrompt());
                }
                else if (_userSelection == "3")
                {
                    ListingActivity runListingActivity = new ListingActivity ();
                }
                else if (_userSelection == "4")
                {
                    Console.WriteLine ("Come Back soon!");
                }
                else
                {
                    Console.WriteLine ("Please enter the number of the activity you wish to run.");
                }
            }
        }
    }
}