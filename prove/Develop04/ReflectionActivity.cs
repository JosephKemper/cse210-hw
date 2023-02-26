using System;
using System.IO;

public class ReflectionActivity : Activity
{
    private string _activityName = "Reflection Activity";
    private string _activityDescription = "reflect on times in your life when you have shown strength and resilience. This will help you recognize the power your have and how you can use it in other aspects of your life.";
    private int _seconds;
    private int _ponderLength = 15;
    private int _listLength;
    
    private Random _randomIndex = new Random();
    
    private List <string> _promptList = new List<string>();
    private List <string> _questionList = new List<string>();

    public string choosePrompt()
    {
        _promptList.Clear();
         _promptList = System.IO.File.ReadLines("Reflecting Prompts.txt").ToList();
        _listLength = _promptList.Count;
        return  _promptList.ElementAt (_randomIndex.Next(0,_listLength));
    }

    public string chooseQuestion ()
    {
        _questionList.Clear();
        _questionList = System.IO.File.ReadLines("Reflecting Questions.txt").ToList();
        _listLength = _questionList.Count;
        return _questionList.ElementAt (_randomIndex.Next(0,_listLength));
    }

    public void NumberOfQuestions ()
    {
        
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