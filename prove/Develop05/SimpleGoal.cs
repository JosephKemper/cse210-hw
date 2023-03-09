using System;

public class SimpleGoal : Goal
{
    
    public SimpleGoal () : base()
    {
        SetGoalType ("SimpleGoal");
        AddGoalToList(GetGoalType(),GetGoalName(),
        GetGoalDescription(), GetGoalPoints());
    }
}