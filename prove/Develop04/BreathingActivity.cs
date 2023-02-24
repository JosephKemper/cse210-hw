using System;

public class BreathingActivity
{
    private string _activityName = "Breathing Activity";
    private string _activityDescription = "relax by walking you through a deep breathing exercise, where you will breathe in slowly through your nose and exhale slowly through your mouth. Clear your mind and focus on your breathing.";
    private int _breatheInTime = 3;
    private int _holdBreathTime = 2;
    private int _breatheOutTime = 6;
    private int _activityRounds;
    private int _totalTime;

    public int CalculateRounds (int seconds)
    {
        if (seconds < 11)
        {
            _activityRounds = 1;
        }
        else
        {
            if (seconds % 11 == 0)
            {
                _activityRounds = seconds / 11;
            }
            else
            {
                _activityRounds = ((seconds - (seconds % 11))/11)+1;
            }
        }
        return _activityRounds;
    }
}