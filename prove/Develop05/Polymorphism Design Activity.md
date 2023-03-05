<code>
Program Specifications
    1. What does the program do?
        The program will let users set, track, and complete any of 3 different kinds of goals. It will allow the user to earn points for the completion of goals. It will also, allow the user to save and load their goals and progress from a file. The goal types are Simple, Eternal, and Checklist. 
            Simple goals are Goals that are completed once and then they are done, and you earn points after completing it. 
            Eternal goals are never actually done, they are goals you do for the rest of your life. You earn points for each time you complete an Eternal Goal. 
                Stretch goal -- Track the number of times you have completed the Eternal Goal.
            Checklist goals are goals that you want to complete a certain number of times. It will track and display how many times you have completed it. It will give you a set number of points for each time you complete it and bonus points when you complete it the desired number of times. 
            If I have time A Daily goal is one that you set with the idea of doing every day. It will track the last day you missed, how many days you have missed, the last day you completed it, the number of times you have completed it, and how many days in a row you have completed it. I also want it to track your longest streak for days of completing the goal. 
    2. What user inputs does it have?
        The main and sub menu's both take numbers for input. The main menu can be processed as strings, but the menu for selecting which activity you want to complete would have to be converted to an int, so it would be easier to just convert all menu input items to an int. 
        The save and load menu will take a string that is the file name. The file will need to be in the same folder as the program. 
        The goal setting menu, takes strings as input and will convert them into a compound list. 
    3. What output does it produce?
        On the main menu, it prints to the console a 6 item numbered menu including the options Create New Goal, List Goals, Save Goals, Load Goals, Record Event, and Quit. Above the menu it displays a running total of the number of points you have earned. If you select option 1, it prints a sub menu with the following numbered options, Simple Goal, Eternal Goal, Checklist Goal. For each goal, it asks what the name of the goal, a short description of it is, and how many points it awards upon completion. For the checklist goal, it also asks how many times it need to be completed and how many points for a bonus. It will also let you view the goals and their current progress, and save the goals to a file. 
    4. How does the program end?
        Select option 6 from the main menu. 
</code>
<code>
Determine the classes
    1. What are good candidates for classes in this program?
            Goal, ConstructGoal, SimpleGoal, EternalGoal, ChecklistGoal, Menu, and Program. If I have enough time to add a 4th goal type, then DailyGoal. 
    2. What are the primary responsibilities of each class?
            Program = Runs the program via a while loop that looks for the number 6 to be entered, and then exits the loop. 
            Menu = Generates and display's menu to user, gets input from user on menu level, and calls appropriate class when option is selected.  
            Goal = display's the intro message for each goal, and collects the common elements each goal has, marks a goal as complete, Loads the goals list from file, saves it to a file, marks goals as complete, creates the data type for a goals list, converts goals array to a list based on goal type, and displays the goals for the user to see.
            ConstructGoal = Used by the program to create a data type for the program to use in a list. 
            SimpleGoal = marks simple goals as complete, adds simple goals to goals list, tells the system how to interpret simple goals compound lists, and adds points for completing simple goals.
            EternalGoal = Adds points for completing goals, teaches the program how to read Eternal goals, and add's eternal goals to the list of goals.
            ChecklistGoal = Tracks how many times the goal has been completed, adds points for each time goal has been completed, adds bonus points when goal is complete, teaches the computer how to read a checklist goal.
            DailyGoal = To be planned later. 
</code>
<code>
Define class behaviors
    1. What are the behaviors this class will have in order to fulfill its responsibilities? (In other words, what things should this class do?)
        Goal = 
            SetGoal -- Runs the process to set a goal
            LoadGoals -- Loads goals from a file
            SaveGoals -- Saves goals to a file
            ListGoals -- Displays all goals and their current status
            RecordEvent -- Runs the process of completing a goal and awarding appropriate points
            GetGoalList
            SetGoalList
            GetGoalName
            SetGoalName
            GetGoalDescription
            SetGoalDescription
            GetGoalPoints
            SetGoalPoints
            GetGoalBonus
            SetGoalBonus
            GetCompletionTarget
            SetCompletionTarget
            GetCurrentProgress
            SetCurrentProgress
            GetCompletionStatus
            SetCompletionStatus
        SimpleGoal = 
            RecordEvent = Defines how an event for a SimpleGoal is processed
        EternalGoal = 
            RecordEvent = Defines how an event for an EternalGoal is processed
        ChecklistGoal =  
            SetGoal -- Runs the process of setting a ChecklistGoal
            RecordEvent = Defines how an event for a ChecklistGoal is processed
        Menu = 
            GetUserInput : int -- takes in a string, converts it to a number, and returns the int. 
            DisplayMainMenu : Void -- Displays the main menu
            DisplayGoalsMenu : Void -- Displays the goal selection menu
            DisplayEventMenu : Void -- Fetches the name of each created goal, converts that to a dynamically numbered menu.
            DisplayPoints : Void -- Displays the total points the user has earned at the top of the menu. 
        DailyGoal = To be determined
</code>
<code>
Define class attributes
    1. What attributes does this class need to fulfill its behaviors? (In other words, what variables should this class store?)
        Goal = 
            _goalList : list
            _goalName : string
            _goalDescription : string
            _goalPoints : Int
            _goalBonus : Int
            _completionTarget : int
            _currentProgress : int
            _completionStatus : Bool
        SimpleGoal = 
        EternalGoal = 
        ChecklistGoal = 
        Menu = 
            _userChoice : string
            _currentMenu : string
        Program = 
        DailyGoal = 
            _dailyGoalList
    2. What are the data types of these member variables?
        See above
    3. What constructors should each class have?
        Goal = 
        SimpleGoal = 
        EternalGoal = 
        ChecklistGoal = 
        Menu = It should have 1 constructor for each menu option that will tell the program how to handle each menu. 
        Program = 
        DailyGoal = 
         
</code>
<code>
Define constructors
    1. What constructors should each class have? (In other words, what parameters should you pass in when creating an object of that type.)
        Goal = 
        SimpleGoal = 
        EternalGoal = 
        ChecklistGoal = 
        Menu = 
        Program = 
        DailyGoal = 
    2. What other work needs to be done to set up these objects? (For example, does the constructor need to run code to perform set up tasks, like creating lists, iterating through variables, etc.)
</code>

