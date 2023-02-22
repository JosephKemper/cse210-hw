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

    public void DisplayEndingMessage (int seconds, string activity)
    {
        Console.WriteLine ("Well done!!");
        // Pause with animation goes here
        Console.WriteLine ();

        Console.WriteLine ($"You have completed another {seconds} of the {activity}.");
        // Pause with animation goes here
    }
}