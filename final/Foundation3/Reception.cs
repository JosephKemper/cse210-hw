using System;
/*
Purpose
Generate messages for Receptions
Inputs
Strings containing reception event details
Outputs
3 different messages for each reception
*/
public class Reception : Event{
    private string _email;

    public override void ProcessEventDetails (string unprocessedLine){
        string [] parts = unprocessedLine.Split();
        if (parts[0] == "Reception"){
            _email = parts[6];
            }
        }

    
    public override void DisplayFullDetails (){
        base.DisplayFullDetails();
        Console.WriteLine("RSVP to: ");
        }
    
    public Reception(){
        }
    }