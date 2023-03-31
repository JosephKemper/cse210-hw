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
    private string _email = "default email";

    public override void ProcessEventDetails (string unprocessedLine){
        string [] parts = unprocessedLine.Split("||");
        
            _email = parts[6];
            
        }

    // TODO #25 Bug Email not showing. 
    public override void DisplayFullDetails (){
        base.DisplayFullDetails();
        Console.WriteLine("RSVP to: " + _email);
        }
    
    public Reception(string eventDetails): base(eventDetails) {
        }
    }