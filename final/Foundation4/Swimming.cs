using System;

public class Swimming : Activity{
    /*
    Purpose
    Calculate the distance and pace while swimming, and assemble summary and add to _summaryList
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
        return -1;
        }
    public override double CalculatePace(double minutes, double stat){
        return -1;
        }
    public override double CalculateSpeed(double minutes, double stat){
        return -1;
        }
    public Swimming(string activityInfo) : base(activityInfo){
        }
    }