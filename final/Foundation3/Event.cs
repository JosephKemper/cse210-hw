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
    private string _filename = "EventsList";
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
        }
    
    public void ProcessEvent(string eventDetailString){
        }

    public void DisplayStandardDescription(){
        }
    
    public void DisplayShortDescription (){
        }
    
    // possible need of getters and setters
    public Event (){
        }

    }