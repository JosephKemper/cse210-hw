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
    private string _activity;
    private double _minutes;
    private double _stat;
    private double _distance;
    private double _speed;
    private double _laps;
    private double _pace;
    private string _date;
    
    private List<string> _summaryList = new List<string>();

    public virtual void LoadActivity (string activityInfo){
        string [] parts = activityInfo.Split(",");
        _activity = parts [0];
        //Console.WriteLine (_activity);
        _minutes = double.Parse(parts [1]);
        //Console.WriteLine (_minutes);
        _stat = double.Parse(parts [2]);
        //Console.WriteLine (_stat);
        }

    public virtual void CalculateDistance(){
        }
    public virtual void CalculateSpeed(){
        }
    public virtual void CalculatePace(){
        }
    public void GetDate (){
        _date = DateTime.Now.ToString("dddd, dd MMMM, yyyy");
        }
    public virtual void CreateSummary (){
        }
    public Activity(string activityInfo){
        LoadActivity(activityInfo);
        GetDate();
        }
    }