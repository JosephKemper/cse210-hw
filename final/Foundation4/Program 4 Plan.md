Program 4: Polymorphism with Exercise Tracking

<Code>
Program Purpose
    Generate statistics for 3 different kinds of exercises
Program Inputs
    File containing activity type, length of time spent on activity, and the appropriate info based on each individual activity.
Program Outputs
    Summary of each activity including calculating several stats for each activity. 
Classes
    Activity, Running, Cycling, and Swimming
</Code>

<Code>
Activity
    Purpose
        Build the core of each exercise that will be shared by all three activity types
    Inputs
        File containing raw activity data
    Outputs
        The needed data for each class to run
    Methods
        LoadActivities (fileName : String)
        GetActivity(activityList) : String
        CalculateDistance()
        CalculateSpeed()
        CalculatePace()
        GetDate () : String
        GetSummary() : String
        GetDistance () : Double
        SetDistance (distance)
        GetSpeed () : Double
        GetLaps () : Double
        SetLaps ()
        GetPace () : Double
        GetMinutes () : Double
        SetMinutes ()
    MemberVariables
        _activities :List < string>
        _distance : Double
        _speed : Double
        _laps : Double
        _pace : Double
        _date : String
        _minutes : Double
        _summaryList : List < String>
</Code>

<Code>
Running
    Purpose
        
    Inputs

    Outputs

    Methods

    MemberVariables
</Code>

<Code>
Cycling
    Purpose

    Inputs

    Outputs

    Methods

    MemberVariables
</Code>

<Code>
Swimming
    Purpose

    Inputs

    Outputs

    Methods

    MemberVariables
</Code>