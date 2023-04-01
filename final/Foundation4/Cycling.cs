using System;

public class Cycling : Activity{
    /*
    Purpose
    Calculate cycling distance and pace, and assemble summary and add to _summaryList
    Inputs
    String Containing Activity
    Outputs
    Summary of Activity including date, 
    activity name, 
    time spent in activity, 
    distance traveled, 
    speed, 
    pace (minutes per mile)
    */
    public override double CalculateDistance(double minutes, double stat){
        // stat == Speed
        return stat * (minutes/60);
        }
    public override double CalculateSpeed(double minutes, double stat){
    return stat;
    }
    public override double CalculatePace(double minutes, double stat){
        return minutes/CalculateDistance(minutes, stat);
        }
    
    public Cycling (string activityInfo) : base(activityInfo){
        }
    }