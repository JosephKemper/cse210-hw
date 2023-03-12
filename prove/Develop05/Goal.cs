using System;

public class Goal
{
    private List <string> _goalList = new List<string>();
    private string _goalName;
    private string _goalDescription;
    private int _goalPoints;
    private int _goalBonus;
    private int _completionTarget;
    private int _currentProgress;
    private bool _isCompleted;
    private string _goalType;
    private int _totalPoints = 0;
    private int _goalIndex;

    public void AddNewGoalToList (string goalString)
    {

        Console.WriteLine($"The _goalList has {_goalList.Count} items in it.");
        _goalList.Add(goalString);
        Console.WriteLine($"The _goalList has {_goalList.Count} items in it.");
    }
    
    public virtual void CreateGoal()
    {
        Console.Write ("What is the name of your goal? ");
        _goalName = Console.ReadLine();
        Console.Write ("What is a short description of it? ");
        _goalDescription = Console.ReadLine();
        Console.Write ("What are the points associated with this goal? ");
        _goalPoints = int.Parse(Console.ReadLine());
    }
    public void CalculateTotalPoints (int points)
    {
        _totalPoints += points;
    }
    public void StoreTotalPoints ()
    {
        _goalList.Add($"{_totalPoints}");
    }
    public void LoadGoals()
    {

    }

    public void SaveGoals ()
    {
    }
    // TODO #17 Bug Goals are adding to list, but not being displayed to consol.
    public void ListGoals ()
    {
        Console.WriteLine ();
        Console.WriteLine ("The goals are:");
        for (int i = 1; i < _goalList.Count; i++)
        {
            string goal = _goalList[i];
            Console.WriteLine (goal);
        }
    }

    public void RecordEvent ()
    {
    }

    public int GetGoalIndex()
    {
        SetGoalIndex();
        return _goalIndex;
    }
    public void SetGoalIndex()
    {
        _goalIndex = _goalList.Count;
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

    public int GetGoalPoints ()
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

    public string GetGoalType ()
    {
        return _goalType;
    }
    public void SetGoalType (string goalType)
    {
        _goalType = goalType;
    }

    public int GetTotalPoints ()
    {
        return _totalPoints;
    }
    public void SetTotalPoints (int totalPoints)
    {
        _totalPoints = totalPoints;
    }
    public void AddToTotalPoints (int newPoints)
    {
        _totalPoints += newPoints;
    }
    public virtual void AddGoalToList (string type, int index,
    string name, string description, int points)
    {
        
        // Goal formats
        
        // EternalGoal
        // Type|~|Index|~|Name|~|Description|~|Points
        //ChecklistGoal
        // Type|~|Index|~|Name|~|Description|~|Points|~|BonusPoints|~|Target|~|Count

    }
    public Goal ()
    {
        StoreTotalPoints();
    }
    public Goal (int number)
    {
    }
}