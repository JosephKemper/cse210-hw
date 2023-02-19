Activity

DisplayIntroMessage be called by the constructor for the specific activity, and will take in _activityName and _activityDescription to populate the intro text for the activity. 

DisplayEndingMessage be called by the constructor for the specific activity and will take in _intSeconds and _activityName to display the ending text of the activity. 

PauseWithSpinner method, will take in the number of milliseconds the output needs to be paused for, and will then use that to govern a while loop that will display the spinner animation for the right amount of time. 

PauseWithTimer will take in both the number of seconds and the number of milliseconds the activity needs to be paused by and will use that to govern a while loop that will count down the appropriate amount of time.

ConvertSeconds method, will take in the user input seconds, and attach it as an int to _intSeconds.

ReturnSeconds method will return the number of seconds the user entered


BreathingActivity

Will not run for exactly the number of seconds they choose. It will run for a number of rounds of breathing that can start within the allotted time. Each round will run for 11 seconds. Each round will consist of 3 seconds of breathing in, 2 seconds of holding your breath, and 6 seconds of breathing out. 

CalculateRounds Method, will take in the time and calculate the number of rounds the activity will run for, and will then return that number to be stored in _activityRounds. 

CalculateTotalTime method, will take in the rounds and calculate the total time and return it to be stored in _totalTime

The constructor, BreathingActivity, will teach the program how to call the needed methods to run the app. (More details to come)


ReflectingActivity


ListingActivity
