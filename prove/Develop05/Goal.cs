using System;

public class Goal
{
    private List <List<Object>> _goalList = new List<List<Object>>();
    private string _goalName;
    private string _goalDescription;
    private int _goalPoints;
    private int _goalBonus;
    private int _completionTarget;
    private int _currentProgress;
    private bool _isCompleted;
    private string _goalType;
    private int _totalPoints;

    public void LoadGoals()
    {
    }

    public void SaveGoals ()
    {
    }

    public void ListGoals ()
    {
        foreach (var i in _goalList)
        {
            Console.WriteLine (i);
        }
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
    public void AddGoalToList (string goalType, 
    string goalName, string goalDescription, int goalPoints, 
    int goalIndex =0,bool isCompleted= false, int goalBonus =0, 
    int completionTarget =0, int currentProgress= 0)
    {
        // goalIndex will be to organize the goals and keep track of updating them. 
        //New SimpleGoal or new Eternal Goal 
        if (goalBonus == 0 && completionTarget ==0 && currentProgress == 0 && isCompleted == false)
        {
        _goalList.Add(new List<object> {goalType,goalName,goalPoints});
        }
        //Completed SimpleGoal

        //ChecklistGoal
        
    }
    public Goal ()
    {
        Console.Write ("What is the name of your goal? ");
        _goalName = Console.ReadLine();
        Console.Write ("What is a short description of it? ");
        _goalDescription = Console.ReadLine();
        Console.Write ("What are the points associated with this goal? ");
        _goalPoints = int.Parse(Console.ReadLine());
    }
    public Goal (int number)
    {
    }
}