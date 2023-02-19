There should be 4 classes in addition to the main program class
Activity, BreathingActivity, ReflectionActivity, and ListingActivity

Class Program
<Code>
While not 4
    Menu options
    1. Start breathing activity
    2. Start reflecting Activity
    3. Start listening Activity
    4. Quit
    Select a choice from the menu: 
        If/else if statements checking for user selection
        Load appropriate activity or end program if 4 is selected
</Code>

Class Activity
<Code>
    Member Variables
        _getSeconds :String
        _intSeconds : Int
        _milliseconds : Int

    Methods
        DisplayIntroMessage (activityName:string, activityDescription:String) :Void
        DisplayEndingMessage (Seconds: int, activityName:String) :Void
        PauseWithSpinner (milliseconds int) :Void
        PauseWithTimer (milliseconds :int, seconds) :Void
        ConvertSeconds (_getSeconds)
        ReturnSeconds()Int
</Code>

Class BreathingActivity

<Code>
    Member Variables
        _activityName
        _activityDescription
        _breatheInTime
        _breatheOutTime
        _holdBreathTime
        _activityRounds
        _totalTime

    Methods
        CalculateRounds (seconds : Int) : Int
        CalculateTotalTime (rounds) : Int
        BreathingActivity(seconds)
</Code>

ReflectionActivity
<Code>
    Member Variables
        _activityName
        _activityDescription


    Methods
</Code>

ListingActivity
<Code>
    Member Variables
        _activityName
        _activityDescription

    Methods
</Code>