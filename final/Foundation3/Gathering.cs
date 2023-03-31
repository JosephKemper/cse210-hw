using System;
/*
Purpose
Strings containing Gathering event details
Inputs
Strings containing Gathering event details
Outputs
3 different messages for each gathering
*/

public class Gathering : Event{
    private string _forecast;

    
    public override void DisplayFullDetails (){
        base.DisplayFullDetails();
        Console.WriteLine("Weather Report: " + _forecast);
        }
    public override void ProcessEventDetails (string unprocessedLine){
        string [] parts = unprocessedLine.Split("||");
            _forecast = parts[6];
            
        }
        
    public Gathering(string eventDetails): base(eventDetails){
        }
    }