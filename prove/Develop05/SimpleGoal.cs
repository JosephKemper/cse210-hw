using System;

public class SimpleGoal : Goal
{
    
    // SimpleGoal
    // Type|~|Index|~|Name|~|Description|~|Points|~|isComplete
    public void AddGoalToList (string type, int index,
    string name, string description, int points, bool isComplete)
    {
        Console.WriteLine ($"{type}|~|{index}|~|{name}|~|{description}|~|{points}|~|{isComplete}");
    }
    
    public SimpleGoal () : base()
    {
        
    }
}