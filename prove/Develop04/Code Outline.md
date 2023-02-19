There should be 4 classes in addition to the main program class
Activity, BreathingActivity, ReflectionActivity, and ListingActivity

Class Program
<Code>
_userSelection

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
        ReturnName (activityName) :String
        ReturnDescription (activityDescription) : String
</Code>

Class BreathingActivity

<Code>
    Member Variables
        _activityName
        _activityDescription
        _breatheInTime = 3
        _breatheOutTime = 2
        _holdBreathTime = 6
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
    GetPrompt () :String
    GetQuestion () :String
    DisplayPrompt () :Void
    DisplayQuestion () Void
    
</Code>

ListingActivity
<Code>
    Member Variables
        _activityName
        _activityDescription

    Methods
</Code>