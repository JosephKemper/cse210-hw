using System;
using System.IO;

public class BreathingActivity : Activity
{
    private string _activityName = "Breathing Activity";
    private string _activityDescription = "relax by walking you through a deep breathing exercise, where you will breathe in slowly through your nose and exhale slowly through your mouth. Clear your mind and focus on your breathing.";
    private int _breatheInTime = 3;
    private int _holdBreathTime = 2;
    private int _breatheOutTime = 6;
    private int _roundLength = 11;
    private int _activityRounds;
    private int _totalTime;
    private int _currentRound;
    private int _seconds;

    
    public BreathingActivity ()
    {
        DisplayIntroMessage (_activityName,_activityDescription);

        _seconds = GetSeconds ();
        

        _activityRounds = CalculateRounds (_seconds, _roundLength);
        _totalTime = CalculateTotalTime (_activityRounds, _roundLength);
        GetReady ();

        _currentRound = 0;
        while (_currentRound < _activityRounds)
        {
            _currentRound += 1;
            
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