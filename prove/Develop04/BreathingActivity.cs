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
    private int _currentRound;
    private int _seconds;

    // Teaches the computer how to run the breathing activity
    public BreathingActivity ()
    {
        DisplayIntroMessage (_activityName,_activityDescription);

        _seconds = GetSeconds ();
        

        _activityRounds = CalculateRounds (_seconds, _roundLength);

        // Part of the stretch activity
        TimeExplanation (_activityName,_seconds,_roundLength);
        
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
        DisplayEndingMessage (CalculateTotalTime (_activityRounds, _roundLength), _activityName);
    }
}