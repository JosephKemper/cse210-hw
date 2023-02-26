using System;
using System.IO;

public class ListingActivity : Activity
{
    private string _activityName = "Listing Activity";
    private string _activityDescription = "reflect on the good things in your life by having your list as many things as you can in a certain area.";
    private int _seconds;
    private string _userInput;
    private List <string> _promptList = new List<string>();
    private Random _randomIndex = new Random();
    
    private List <string> _userList = new List<string>();
    private int _listLength;

    public string GetPrompt ()
    {
        _promptList.Clear();
         _promptList = System.IO.File.ReadLines("Listing Prompts.txt").ToList();
        _listLength = _promptList.Count;
        return  _promptList.ElementAt (_randomIndex.Next(0,_listLength));
    }
    public ListingActivity ()
    {
        DisplayIntroMessage (_activityName, _activityDescription);
        _seconds = GetSeconds ();

        GetReady();

        Console.WriteLine ("List as many responses as you can to the following prompt: ");

        
        Console.WriteLine ($"--- {GetPrompt ()} ---");

        BeginCountdown ();

        DateTime _startTime = DateTime.Now;
        DateTime _endTime = _startTime.AddSeconds (_seconds);
        
        while (DateTime.Now < _endTime)
        {
            _userInput = Console.ReadLine ();
            _userList.Add (_userInput);
        }
        _listLength = _userList.Count;

        Console.WriteLine ();
        Console.WriteLine ($"You listed {_listLength} items!");


        DisplayEndingMessage (_seconds, _activityName);
    }
}