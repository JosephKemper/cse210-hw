using System;

public class Activity
{
    private string _getSeconds;
    private string _intSeconds;

    public void DisplayIntroMessage (string activityName, string activityDescription)
    {
        Console.WriteLine ($"Welcome to the {activityName}");
        Console.WriteLine ($"This activity will help you {activityDescription}");

    }
}