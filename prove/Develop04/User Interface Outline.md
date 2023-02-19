<code>
upon start
    Menu loads 
        Menu Options:
          1. Start Breathing Activity
          2. Start Reflecting Activity
          3. Start Listing Activity
          4. Quit
        Select a choice from the menu: 

Program takes a number between 1 to 4 from the user

User enters 1
    Breathing Activity starts
        Intro Text Displayed
            Welcome to the Breathing Activity

            This activity will help you relax by walking you through a deep breathing exercise, where you will breathe in slowly through your nose and exhale slowly through your mouth. Clear your mind and focus on your breathing.

            How long, in seconds, would you like for your session? 
        
        Program takes an integer from the user
        Tells user to get ready
        Pauses the program for a short time
        Displays animation while the program is paused

        prints and empty line
        Displays Breathe in to user with count down timer
        Displays Now breathe out to the user with a count down timer
        Continues the breathe in/breathe out cycle based on the length of time the user input.

    Upon activity completion
        Displays completion text to user
            Well done!!
            Pauses application with animation to give user time to read

            You have completed another 30 seconds of the Breathing Activity.
        Pauses application with animation to give user time to read
        Displays animation while program is paused. 
    Returns to main menu

User enters 2
    Reflecting Activity Starts
        Intro Text Displayed
            Welcome to the Reflecting Activity
            This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power your have and how you can use it in other aspects of your life.

            How long, in seconds, would you like for your session? 

        Program takes an integer from the user
        Tells user to get ready
        Pauses the program for a short time
        Displays animation while the program is paused

        prints and empty line

        Display's the following text
            Consider the following prompt:
            Prints an empty line
            --- Think of a time when you did something really difficult ---
            Prints an empty line
            When you have something in mind, press enter to continue.
        Waits for the user to hit enter before continuing
        Prints an empty line
        Now ponder on each of the following questions as they relate to the experience
        You may begin in: [Count down timer displayed]

        Displays a series of random questions pulled from list. Examples shows below.
        How did you feel when it was complete? [Animation displayed while program pauses]
            [After undisclosed amount of time, the activity proceeds to the next question]
        What is your favorite thing about this experience? [Animation displayed while program pauses]
            [After undisclosed amount of time, the activity proceeds to the next question]

    Upon activity completion
        Displays completion text to user
            Well done!!
            Pauses application with animation to give user time to read

            You have completed another 30 seconds of the Reflecting Activity.
        Pauses application with animation to give user time to read
        Displays animation while program is paused. 
    Returns to main menu

User Enters 3
    Reflecting Activity Starts
        Intro Text Displayed
        Welcome to the Listing Activity.
        Blank line
        This activity will help you reflect on the good things in your life by having your list as many things as you can in a certain area.
        Blank line
        How long, in seconds, would you like for your session? 

        Program takes an integer from the user
        Tells user to get ready
        Pauses the program for a short time
        Displays animation while the program is paused

        prints and empty line

        List as many responses as you can to the following prompt:

        Displays a random prompt: Example below.

        --- When have you felt the Holy Ghost this month? ---
        You may begin in: [Displays a count down timer]
        
        Allows the user to continue entering new responses until the time runs out. 

        after time ends program displays
            You listed x items! 
            x = number of items the user entered

            Well done!!
            Pauses application with animation to give user time to read

            You have completed another 30 seconds of the Listing Activity.
        Pauses application with animation to give user time to read
        Displays animation while program is paused. 
    Returns to main menu

User enters 4
    Application closes
</code>