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
        CreateSummary ()
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
        Calculate running speed and pace, assemble summary and add to _summaryList
    Inputs
        String Containing Activity
    Outputs
        Summary of Activity including date, activity name, time spent in activity, distance traveled, speed, pace (minutes per mile)
    Methods
        GetActivity(activityList) : String
        CalculateSpeed()
        CalculatePace()
        CreateSummary ()
        Running()
</Code>

<Code>
Cycling
    Purpose
        Calculate cycling distance and pace, and assemble summary and add to _summaryList
    Inputs
        String Containing Activity
    Outputs
        Summary of Activity including date, activity name, time spent in activity, distance traveled, speed, pace (minutes per mile)
    Methods
        GetActivity(activityList) : String
        CalculateDistance()
        CalculatePace()
        CreateSummary ()
        Cycling ()
</Code>

<Code>
Swimming
    Purpose
        Calculate the distance and pace while swimming, and assemble summary and add to _summaryList
    Inputs
        String Containing Activity
    Outputs
        Summary of Activity including date, activity name, time spent in activity, distance traveled, speed, pace (minutes per mile)
    Methods
        GetActivity(activityList) : String
        CalculateDistance()
        CalculatePace()
        CreateSummary ()
</Code>

UML URL
//www.plantuml.com/plantuml/dpng/jPDHIWCn48RVznJpk4Ns0gL8fGLVgeXx01btHmaaQTbCb5AzkncSj9kw54HyIx-P-V-_oUmoC0uSdQrkEZPlXlUm-6YQ1XwZzyQ_dkFLlhCJk7qtpWclLXP3W6FvK5t1Pekz0aC1wXTZwHuTmHnQ7jBKB3NT4kUX6lMmCO5dnwxKj4BRHOjCwrH1tr4z6zDsHzINw06rAUclaGdgKd0WcOlEuR27tAY_YrRXwgeYwsryjfGgxRZIwobBIQIoN_06T-5S9LETbEG_1--CZqmJiwT2rS0JdgvxBhS82mWiV-HQgZdZKK9WaAG5iH9d37PuDjCZdrvHWDCKXV3tRKgCn3LDgsa-TMFoli7XbxjmuTMdtrUDqZbxwrAhzz_tyA9zzXhvwzVpxm7KSqc-Zyv-0G00