using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        Program Purpose
        Generate statistics for 3 different kinds of exercises
        Program Inputs
        File containing activity type, length of time spent on activity, and the appropriate info based on each individual activity.
        Program Outputs
        Summary of each activity including calculating several stats for each activity. 
        Classes
        Activity, Running, Cycling, and Swimming
        */
        /* 
        File format
        Activity,Time,activity specific stat
        for running the stat is distance
        for cycling it is speed
        for swimming it is laps
        */
        string exerciseFile = "Exercises.txt";
        List <string> exerciseList = new List<string>();
        
        Console.WriteLine("Program 4: Polymorphism with Exercise Tracking");

        foreach (string line in File.ReadLines(exerciseFile)){
            exerciseList.Add(line);
            }
        foreach (string activity in exerciseList){
            Activity newActivity = new Activity(activity);
            }
    }
}