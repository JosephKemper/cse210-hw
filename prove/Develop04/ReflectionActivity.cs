using System;

public class ReflectionActivity : Activity
{
    private string _activityName = "Reflection Activity";
    private string _activityDescription = "reflect on times in your life when you have shown strength and resilience. This will help you recognize the power your have and how you can use it in other aspects of your life.";
    private string _seconds;


    
    public ReflectionActivity()
    {
    DisplayIntroMessage (_activityName,_activityDescription);
    Console.WriteLine ();

    _seconds = GetSeconds ();
    GetReady ();
    
    }
}