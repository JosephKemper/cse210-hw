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

    public void LoadGatheringEvent(){
        }
    
    public override void DisplayFullDetails (){
        base.DisplayFullDetails();
        Console.WriteLine("Weather Report: " + _forecast);
        }

    public Gathering(){
        }
    }