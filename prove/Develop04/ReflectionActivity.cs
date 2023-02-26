using System;
using System.IO;

public class ReflectionActivity : Activity
{
    private string _activityName = "Reflection Activity";
    private string _activityDescription = "reflect on times in your life when you have shown strength and resilience. This will help you recognize the power your have and how you can use it in other aspects of your life.";
    private string _seconds;
    private int _listLength;
    private string _currentPrompt;
    
    private Random _randomIndex = new Random();
    
    private List <string> _promptList = new List<string>();
    private List <string> _questionList = new List<string>();

    public string choosePrompt()
    {
        _promptList.Clear();
         _promptList = System.IO.File.ReadLines("Reflecting Prompts.txt").ToList();
        _listLength = _promptList.Count;
        _currentPrompt = _promptList.ElementAt (_randomIndex.Next(0,_listLength));
        return _currentPrompt;
    }

    public void chooseQuestion ()
    {
        _questionList = System.IO.File.ReadLines("Reflecting Questions.txt").ToList();
    }


    
    public ReflectionActivity()
    {
    DisplayIntroMessage (_activityName,_activityDescription);
    Console.WriteLine ();

    _seconds = GetSeconds ();
    GetReady ();

    Console.WriteLine ("Consider the following prompt:");
    Console.WriteLine ();

    }
}