using System;

/*
Purpose
Process and store all details shared by each event type
Inputs
File containing details for 3 different kinds of events.
Outputs
Any shared program details
*/

public class Event{
    private string _title = "default title";
    private string _eventType = "default event type";
    private string _description = "default description";
    private string _date = "default description";
    private string _time = "default time";
    private string _address = "default location";
    private string _eventsFile = "Events.txt";
    protected List<string> _eventList = new List<string>();

    public void LoadEvents(string filename){
        // All Events have the following format
        // Event Type|Date|Time|Address|Description|Title
        // Following that are details customized to each event type
        // Lecture events have
        // |Speaker|Capacity
        // Reception Events have
        // |RSVP email
        // Gatherings have 
        // |Weather forecast
        _eventList.Clear();
        foreach (string line in File.ReadLines(_eventsFile)){
            _eventList.Add(line);
            }
        }
    public void ProcessEvent(){
        foreach (string line in _eventList){
            // All Events have the following format
        // Event Type|Date|Time|Address|Description|Title
        // Following that are details customized to each event type
        // Lecture events have
        // |Speaker|Capacity
        // Reception Events have
        // |RSVP email
        // Gatherings have 
        // |Weather forecast
            string [] parts = line.Split("||");
            _eventType = parts [0];
            _date = parts [1];
            _time = parts [2];
            _address = parts [3];
            _description = parts [4];
            _title = parts [5];
            ProcessEventDetails (line);

            Console.WriteLine("Short Description");
            DisplayShortDescription();

            Console.WriteLine ("---End Description---");
            Console.WriteLine("Standard Description");
            DisplayStandardDescription ();

            Console.WriteLine ("---End Description---");
            Console.WriteLine("Full Description");
            DisplayFullDetails();

            Console.WriteLine ("---End Description---");
            }
        }
    public virtual void ProcessEventDetails(string unprocessedLine){
    }

    public void DisplayStandardDescription(){
        DisplayShortDescription();
        Console.WriteLine("Time: " + _time);
        Console.WriteLine("Address: " + _address);
        Console.WriteLine("Description: " + _description);
        Console.WriteLine();
        }
    
    public void DisplayShortDescription (){
        Console.WriteLine ($"Announcing our next {_eventType}!");
        Console.WriteLine("Title: " + _title);
        Console.WriteLine("Date: " + _date);
        }
    
    public virtual void DisplayFullDetails(){
        DisplayStandardDescription();
        }
    
    // possible need of getters and setters
    // Combined Getter/Setter format learned from Bing AI.
    // To use this template it gave the following example
    /*
    For example, 
    if you have an instance of the Event class called myEvent, 
    you can get the value of the Title property like this: 
    string title = myEvent.Title;. 
    You can also set the value of the Title property like this: 
    myEvent.Title = "New Title";.
    */
    public string Title{
        get { return _title; }
        set { _title = value; }
        }
    public Event (){
        LoadEvents(_eventsFile);
        ProcessEvent();
        }

    }