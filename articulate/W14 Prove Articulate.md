<p>Joseph D. Kemper</p>
<p>CSE 210-09: Programming with Classes</p>
<p>W14 Prove: Articulate</p>
<p>31 March 2023</p>
<p></p>
<p>Foundation 4 Articulate</p>
<p></p>
<p>Abstraction</p>
<p></p>
<p>
To me, abstraction is the planning part of programming. Abstraction involves taking a complex idea, simplifying it down to its most basic elements, and then using that to help you plan out how you will build your program. For me, one of the most valuable parts of abstraction is the process of asking what is the purpose of this program, and then asking the same question about each class, and even possibly asking the same question about each method you are writing. From there, you take and record the inputs that structure will take, and then the outputs it will return, and add all of that as a comment to your code to help you remember what your goal is. Here is one example of how that might look.
</p>
<code>
    Purpose
        Build the core of each exercise that will be shared by all three activity types
    Inputs
        File containing raw activity data
    Outputs
        The needed data for each class to run
</code>
<p></p>
<p>
One of the biggest benefits of abstraction I have found is that it helps you get a clearer idea of what your goals are and how you plan on getting there, and abstraction does not have to be reserved for just that time before you start writing your code. When you are stuck, stepping back and taking another high level look at both your code and where you want to go, can be extremely beneficial. 
</p>
<p></p>
<p>Encapsulation</p>
<p></p>
<p>
Encapsulation to me, is the principle that allows your code to be most easily updated and changed. Through keeping everything private, it forces you to make your code more modular, which in turn both makes it more reusable and easier to update. Take for example the following code, because all of the variables in question are private, I was forced to make it more modular, and instead of having to write it 3 times, I only ended up having to write it once. Now, thanks to that, if I ever want to change up how my summary looks, I only have to go to one area instead of three. Yes, in this case, I also used the principle of inheritance to implement this but, I only thought about it, because I first kept all of the variables private. 
</p>
<p></p>
<code>
public void CreateSummary (double minutes, double stat){
        Console.WriteLine($"{_date}, {_activity} ({_minutes} min)- Distance {Math.Round(CalculateDistance(minutes, stat),2)}, Speed {Math.Round(CalculateSpeed(minutes, stat),2)} mph, Pace: {Math.Round(CalculatePace(minutes, stat),2)} min per mile");
        }
</code>
<p></p>
<p>Inheritance</p>
<p></p>
<p>
As I suggested with my explanation on encapsulation, inheritance is about reusing your code. You write it once, and then have everything else that needs to use that, simply inherit from it. Take for example the constructor for my activity class and the CreateSummary method detailed above, instead of copying and pasting the same code into every class, I simply wrote the activity class in such a way that I was able to reuse the same code for every class. The constructors for the other classes simply had one little code segment that said I wanted it to use everything I put in the base constructor, and then the computer did the rest for me. 
</p>
<p></p>
<code>
public Activity(string activityInfo){
        LoadActivity(activityInfo);
        GetDate();
        CreateSummary(_minutes,_stat);
        }
</code>
<p></p>
<p>Polymorphism</p>
<p></p>
<p>

</p>
<p></p>
<code>

</code>
