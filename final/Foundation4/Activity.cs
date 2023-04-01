using System;

public abstract class Activity{
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

    public void LoadActivity (string activityInfo){
        string [] parts = activityInfo.Split(",");
        _activity = parts [0];
        //Console.WriteLine (_activity);
        _minutes = double.Parse(parts [1]);
        //Console.WriteLine (_minutes);
        _stat = double.Parse(parts [2]);
        //Console.WriteLine (_stat);
        }

    public abstract double CalculateDistance(double minutes, double stat);
    public abstract double CalculateSpeed(double minutes, double stat);
    public abstract double CalculatePace(double minutes, double stat);
    public void GetDate (){
        _date = DateTime.Now.ToString("dd MMM yyyy");
        }
    public void CreateSummary (double minutes, double stat){
        //03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
        Console.WriteLine($"{_date}, {_activity} ({_minutes} min)- Distance {Math.Round(CalculateDistance(minutes, stat),2)}, Speed {Math.Round(CalculateSpeed(minutes, stat),2)} mph, Pace: {Math.Round(CalculatePace(minutes, stat),2)} min per mile");
        }
    public Activity(string activityInfo){
        LoadActivity(activityInfo);
        GetDate();
        CreateSummary(_minutes,_stat);
        }
    }