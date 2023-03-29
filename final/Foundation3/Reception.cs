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

    public void LoadReceptionEvent(){
        }
    
    public void DisplayFullDetails (){
        base.DisplayFullDetails();
        Console.WriteLine("RSVP to: ");
        }
    
    public Reception(){
        }
    }