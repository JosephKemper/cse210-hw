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
    public override double CalculatePace(double minutes, double stat){
        return minutes/CalculateDistance(minutes, stat);
        }
    public override void CreateSummary (){
        //03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
        
        }
    public Cycling (string activityInfo) : base(activityInfo){
        }
    }