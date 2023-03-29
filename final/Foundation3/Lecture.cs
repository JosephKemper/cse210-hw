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
    
    public override void DisplayFullDetails () {
        base.DisplayFullDetails();
        Console.WriteLine("Speaker: " + _speaker);
        Console.WriteLine("Capacity: " + _capacity);
        }
    public override void ProcessEventDetails (string unprocessedLine){
        string [] parts = unprocessedLine.Split();
        if (parts[0] == "Lecture"){
            _speaker = parts[6];
            _capacity = parts[7];
            }
        }
    public Lecture(){
        }
    }