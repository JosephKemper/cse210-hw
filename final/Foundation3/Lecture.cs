using System;
/*
Purpose
Generate messages for Lectures
Inputs
Strings containing lecture event details
Outputs
3 different messages for each lecture.
*/
public class Lecture : Event{
    private string _speaker = "default Speaker";
    private string _capacity = "default seats";

    public void LoadLectureEvent(){
        }
    
    public void DisplayFullDetails () {
        base.DisplayFullDetails();
        Console.WriteLine("Speaker: " + _speaker);
        Console.WriteLine("Capacity: " + _capacity);
        }
    
    public Lecture(){
        }
    }