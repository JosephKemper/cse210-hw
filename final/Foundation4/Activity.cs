using System;

public class Activity{
    /*
    Purpose
    Build the core of each exercise that will be shared by all three activity types
    Inputs
    File containing raw activity data
    Outputs
    The needed data for each class to run
    */
    private List<string> _activities = new List<string>();
    private double _distance;
    private double _speed;
    private double _laps;
    private double _pace;
    private string _date;
    private double _minutes;
    private List<string> _summaryList = new List<string>();

    public virtual void LoadActivities (string fileName){
        }
    public virtual void GetActivity(string activityList){
        }
    public virtual void CalculateDistance(){
        }
    public virtual void CalculateSpeed(){
        }
    public virtual void CalculatePace(){
        }
    public void GetDate (){
        }
    public virtual void CreateSummary (){
        }
    }