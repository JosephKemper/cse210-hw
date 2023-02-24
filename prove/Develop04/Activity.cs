using System;

public class Activity
{
    private string _getSeconds;
    private int _intSeconds;
    private int _pausedCounter;

    public void DisplayIntroMessage (string activityName, string activityDescription)
    {
        Console.WriteLine ($"Welcome to the {activityName}");
        Console.WriteLine ($"This activity will help you {activityDescription}");
    }

    public void DisplayEndingMessage (int seconds, string activity)
    {
        Console.WriteLine ("Well done!!");
        PauseWithSpinner(5);
        Console.WriteLine ();

        Console.WriteLine ($"You have completed another {seconds} of the {activity}.");
        PauseWithSpinner(5);
    }

    public void PauseWithSpinner (int seconds)
    {
        _pausedCounter = 0;

        while (_pausedCounter < seconds)
        {
        _pausedCounter += 1;
        Console.Write ("-");

        Thread.Sleep(250);
        Console.Write ("\b \b");

        Console.Write ("""\""");

        Thread.Sleep(250);
        Console.Write("\b \b");
        
        Console.Write ("|");

        Thread.Sleep(250);
        Console.Write("\b \b");
        
        Console.Write ("/");

        Thread.Sleep(250);
        Console.Write("\b \b");
        }
        Console.WriteLine();
    }
    
    public int ReturnSeconds ()
    {
        return _intSeconds;
    }

    public string ReturnName (string activityName)
    {
        return activityName;
    }

    public string ReturnDescription (string activityDescription)
    {
        return activityDescription;
    }
}