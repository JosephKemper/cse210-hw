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


    public void DisplayIntroMessage (string activityName, string activityDescription)
    {
        Console.WriteLine ($"Welcome to the {activityName}");
        Console.WriteLine ($"This activity will help you {activityDescription}");
    }

    public void DisplayEndingMessage (int seconds, string activity)
    {
        Console.WriteLine ("Well done!!");
        PauseWithSpinner(_readyTime);
        Console.WriteLine ();

        Console.WriteLine ($"You have completed another {seconds} seconds of the {activity}.");
        PauseWithSpinner(_readyTime);
    }

    public void BeginCountdown ()
    {
        Console.Write ("You may begin in: ");
        PauseWithTimer (_readyTime);
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

    public int GetSeconds ()
    {
        Console.Write ("How long, in seconds, would you like for your session? ");
        _getSeconds = Console.ReadLine ();
        Console.WriteLine ();

        _intSeconds = int.Parse(_getSeconds);
        return _intSeconds;
    }
    public void GetReady ()
    {
        Console.WriteLine ("Get Ready");
        
        PauseWithSpinner (ReturnReadyTime());

        Console.WriteLine ();
    }

    public int ReturnReadyTime()
    {
    return _readyTime;
    }

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

    public int CalculateTotalTime(int rounds, int roundLength)
    {
        _totalTime = rounds *roundLength;
        return _totalTime;
    }
}