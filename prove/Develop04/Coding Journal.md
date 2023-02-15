<h1>
    W07 Team Activity: Designer
</h1>
<p>
For core requirements, 4 classes. One class that has all of the shared mindfulness activity traits and one sub class for each activity. My first thought for a stretch goal was to keep it simple and add an extra activity. I'm not sure what that will be right now, but I want to get the core program running first. 
</p>

<h3>
Functional requirements
</h3>
<code>
Have a menu system to allow the user to choose an activity.
</code>
<p>
Simple and self explanatory. Likely will be included nested under a while loop unless it becomes overly complex that will exit when the user selects the option to quit.
</p>
<code>
Each activity should start with a common starting message that provides the name of the activity, a description, and asks for and sets the duration of the activity in seconds. Then, it should tell the user to prepare to begin and pause for several seconds.
</code>
<p>
Users should not be asked for time in milliseconds. The sleep function, uses milliseconds. So, that means I will need to take a number of seconds from the user, convert it into milliseconds and feed that variable into the sleep timer. So, I will need one variable to get the number from the user, another to convert it into an int, and a third to convert it into milliseconds. There are 1000 milliseconds in a second. 
</p>
<p>
The Activity class should have a method that will take in one argument that will complete the sentence that will describe what the activity will do. It should be a void type, and will print the completed activity to the console.
</p>
<code>
Each activity should end with a common ending message that tells the user they have done a good job, and pause and then tell them the activity they have completed and the length of time and pauses for several seconds before finishing.
</code>
<p>
</p>
<code>
Whenever the application pauses it should show some kind of animation to the user, such as a spinner, a countdown timer, or periods being displayed to the screen.
</code>
<p>
</p>
<code>
The interface for the program should remain generally true to the one shown in the video demo.
</code>
<p>
</p>
<code>
Provide activities for reflection, breathing, and enumeration, as described below:
</code>
<p>
</p>