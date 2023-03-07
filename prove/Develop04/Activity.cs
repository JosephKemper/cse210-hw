using System;
using System.IO;

public class Activity
{
    private string _getSeconds;
    private int _intSeconds;
    private int _pausedCounter;
    private int _readyTime = 5;
    private int _countDownTimer;
    private int _totalTime;
    private int _activityRounds;

    
    // Displays the introductory info to the user about each activity.
    public void DisplayIntroMessage (string activityName, string activityDescription)
    {
        Console.WriteLine ($"Welcome to the {activityName}");
        Console.WriteLine ($"This activity will help you {activityDescription}");
    }

    // Displays the end of activity info for the user
    public void DisplayEndingMessage (int seconds, string activity)
    {
        Console.WriteLine ("Well done!!");
        PauseWithSpinner(_readyTime);
        Console.WriteLine ();

        Console.WriteLine ($"You have completed another {seconds} seconds of the {activity}.");
        PauseWithSpinner(_readyTime);
    }

    /* Stretch goal 
    Let the user know about some behind the scenes calculations 
    that were made if applicable.
    */
    public void TimeExplanation (string activityName, int seconds, int roundLength)
    {
        if (seconds % roundLength != 0)
        {
            _activityRounds = CalculateRounds (seconds, roundLength);
            _totalTime = CalculateTotalTime (_activityRounds,roundLength);
            Console.WriteLine ($"Each round of the {activityName} takes a minimum of {roundLength} to complete.");
            Console.WriteLine ($"We will adjust your total activity time to {_totalTime} to give you a better experience.");
        }
    }

    // Used to let the user know when to formally begin
    public void BeginCountdown ()
    {
        Console.Write ("You may begin in: ");
        PauseWithTimer (_readyTime);
    }

    // Used to pause the output while displaying an animation to the user
    public void PauseWithSpinner (int seconds)
    {
        _pausedCounter = 0;

        while (_pausedCounter < seconds)
        {
        _pausedCounter += 1;
        Console.Write ("-");

        Thread.Sleep(250);
        Console.Write ("\b \b");

        Console.Write ("\\");

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

    // Used to pause the output while displaying a countdown timer
    public void PauseWithTimer (int seconds)
    {
        _pausedCounter = 0;
        _countDownTimer = seconds;
        while (_pausedCounter < seconds)
        {
            _pausedCounter += 1;
            Console.Write ($"{_countDownTimer}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            _countDownTimer -= 1;
        }
        Console.WriteLine ();
    }

    // Collect seconds from user convert to int, and return for later use
    public int GetSeconds ()
    {
        Console.Write ("How long, in seconds, would you like for your session? ");
        _getSeconds = Console.ReadLine ();
        Console.WriteLine ();

        _intSeconds = int.Parse(_getSeconds);
        return _intSeconds;
    }

    // Method to let prepare for the start of the activity
    public void GetReady ()
    {
        Console.WriteLine ("Get Ready");
        
        PauseWithSpinner (_readyTime);

        Console.WriteLine ();
    }

    /* 
    Stretch Goal: 
    Instead of just taking the time directly entered by the user
    converted the time to be equal to predetermined round length.
    */
    public int CalculateRounds (int seconds, int roundLength)
    {
        if (seconds < roundLength)
        {
            _activityRounds = 1;
            CalculateTotalTime (_activityRounds, roundLength);
        }
        else
        {
            if (seconds % roundLength == 0)
            {
                _activityRounds = seconds / roundLength;
                CalculateTotalTime (_activityRounds, roundLength);
            }
            else
            {
                _activityRounds = ((seconds - (seconds % roundLength))/roundLength)+1;
                CalculateTotalTime (_activityRounds,roundLength);
            }
        }
        return _activityRounds;
    }

    /* 
    Stretch Goal 
    Calculated the actual time the user would run the activity.
    */
    public int CalculateTotalTime(int rounds, int roundLength)
    {
        _totalTime = rounds *roundLength;
        return _totalTime;
    }
}