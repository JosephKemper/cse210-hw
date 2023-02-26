using System;
using System.IO;

public class ListingActivity : Activity
{
    private string _activityName = "Listing Activity";
    private string _activityDescription = "reflect on the good things in your life by having your list as many things as you can in a certain area.";
    private int _seconds;
    
    private List <string> _userList = new List<string>();
    private string _listLength;

    public void GetPrompt ()
    {
        
    }
    public ListingActivity ()
    {
        DisplayIntroMessage (_activityName, _activityDescription);
        _seconds = GetSeconds ();

        GetReady();

        Console.WriteLine ("List as many responses as you can to the following prompt: ");

        
        DateTime _startTime = DateTime.Now;
        DateTime _endTime = _startTime.AddSeconds (_seconds);

        while (DateTime.Now < _endTime)
        {

        }


        DisplayEndingMessage (_seconds, _activityName);
    }
}