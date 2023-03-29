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
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;
    private string _eventsFile = "EventsList";
    protected List<string> _eventList = new List<string>();

    public void LoadEvents(string filename){
        // All videos have the following format
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
    
    public void ProcessEvent(string eventDetailString){
        }

    public void DisplayStandardDescription(){
        }
    
    public void DisplayShortDescription (){
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
        }

    }