using System;

public class BreathingActivity : Activity
{
    private string _activityName = "Breathing Activity";
    private string _activityDescription = "relax by walking you through a deep breathing exercise, where you will breathe in slowly through your nose and exhale slowly through your mouth. Clear your mind and focus on your breathing.";
    private int _breatheInTime = 3;
    private int _holdBreathTime = 2;
    private int _breatheOutTime = 6;
    private int _activityRounds;
    private int _totalTime;
    private int _currentRound;
    private string _seconds;

    public int CalculateRounds (int seconds)
    {
        if (seconds < 11)
        {
            _activityRounds = 1;
            CalculateTotalTime (_activityRounds);
        }
        else
        {
            if (seconds % 11 == 0)
            {
                _activityRounds = seconds / 11;
                CalculateTotalTime (_activityRounds);
            }
            else
            {
                _activityRounds = ((seconds - (seconds % 11))/11)+1;
                CalculateTotalTime (_activityRounds);
            }
        }
        return _activityRounds;
    }

    public int CalculateTotalTime(int rounds)
    {
        _totalTime = rounds *11;
        return _totalTime;
    }
    public BreathingActivity ()
    {
        DisplayIntroMessage (_activityName,_activityDescription);

        _seconds = GetSeconds ();
        

        _activityRounds = CalculateRounds (ConvertSeconds(_seconds));
        _totalTime = CalculateTotalTime (_activityRounds);
        Console.WriteLine ("Get Ready");
        
        PauseWithSpinner (ReturnReadyTime());

        Console.WriteLine ();

        _currentRound = 0;
        while (_currentRound < _activityRounds)
        {
            _currentRound += 1;
            // TODO #15 Bug BreathingActivity freezes up at first statement
            Console.Write ("Breathe in...");
            PauseWithTimer (_breatheInTime);
            
            Console.Write ("Hold that breath...");
            PauseWithTimer (_holdBreathTime);
            
            Console.Write ("Exhale...");
            PauseWithTimer (_breatheOutTime);
            
            Console.WriteLine ();
            
        }
        Console.WriteLine ();
        DisplayEndingMessage (_totalTime, _activityName);
    }
}