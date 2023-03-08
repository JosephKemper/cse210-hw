using System;

class Goal
{
    private List <Goal> _goalList = new List<Goal>();
    private string _goalName;
    private string _goalDescription;
    private int _goalPoints;
    private int _goalBonus;
    private int _completionTarget;
    private int _currentProgress;
    private bool _isCompleted;

    public void LoadGoals()
    {
    }

    public void SaveGoals ()
    {
    }

    public void ListGoals ()
    {
    }

    public void RecordEvent ()
    {
    }

    public string GetGoalName ()
    {
        return _goalName;
    }
    public void SetGoalName (string goalName)
    {
        _goalName = goalName;
    }

    public string GetGoalDescription ()
    {
        return _goalDescription;
    }

    public void SetGoalDescription (string goalDescription)
    {
        _goalDescription = goalDescription;
    }

    public int GetGoalPints ()
    {
        return _goalPoints;
    }

    public void SetGoalPoints (int goalPoints)
    {
        _goalPoints = goalPoints;
    }

    public int GetGoalBonus ()
    {
        return _goalBonus;
    }

    public void SetGoalBonus (int goalBonus)
    {
        _goalBonus = goalBonus;
    }

    public int GetCompletionTarget ()
    {
        return _completionTarget;
    }

    public void SetCompletionTarget (int completionTarget)
    {
        _completionTarget = completionTarget;
    }

    public int GetCurrentProgress ()
    {
        return _currentProgress;
    }

    public void SetCurrentProgress (int currentProgress)
    {
        _currentProgress = currentProgress;
    }

    public bool GetIsCompleted ()
    {
        return _isCompleted;
    }

    public void SetIsCompleted (bool isCompleted)
    {
        _isCompleted = isCompleted;
    }
}