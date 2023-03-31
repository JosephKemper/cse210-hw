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

            Console.WriteLine();
            Console.WriteLine($"---Announcements for {_eventType}---");

            Console.WriteLine("Short Description");
            Console.WriteLine();
            DisplayShortDescription();
            
            Console.WriteLine();
            Console.WriteLine ("---End Description---");
            Console.WriteLine();

            Console.WriteLine("Standard Description");
            Console.WriteLine();
            DisplayStandardDescription ();
            
            Console.WriteLine();
            Console.WriteLine ("---End Description---");
            Console.WriteLine();

            Console.WriteLine("Full Description");
            Console.WriteLine();
            DisplayFullDetails();

            Console.WriteLine();
            Console.WriteLine ("---End Description---");
            Console.WriteLine();
            Console.WriteLine($"---End of Announcements for {_eventType}");
            }
        }
    public virtual void ProcessEventDetails(string unprocessedLine){
        }
    public void DisplayShortDescription (){
        Console.WriteLine ($"Announcing our next {_eventType}!");
        Console.WriteLine("Title: " + _title);
        Console.WriteLine("Date: " + _date);
        }
    public void DisplayStandardDescription(){
        DisplayShortDescription();
        Console.WriteLine("Time: " + _time);
        Console.WriteLine("Address: ");
        Address newAddress = new Address (_address);
        Console.WriteLine("Description: " + _description);
        }
    
    public virtual void DisplayFullDetails(){
        DisplayStandardDescription();
        }
    
 
    public Event (string eventDetails){
        LoadEvents(eventDetails);
        ProcessEvent();
        }

    }