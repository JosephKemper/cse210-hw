<p>Joseph D. Kemper</p>
<p>CSE 210-09: Programming with Classes</p>
<p>W08 Prove: Articulate</p>
<p>25 February</p>
<p></p>
<p>Inheritance</p>
<p></p>
<p>Explain the meaning of Inheritance</p>
<p></p>
<p>
Inheritance is the process of writing classes in such a way that one class can inherit code written in another (the parent) class. 
</p>
<p></p>
<p>Highlight a benefit of Inheritance</p>
<p></p>
<p>
In addition to saving you the time it would take to write the same code multiple times, (even if you are just copy/pasting the code), Inheritance also allows you to write code that is much more maintainable.
</p>
<p>
Another benefit is that by building code to follow the principle of inheritance, it forces you to think about how to best reuse your code. As I was building my Mindfulness program, I had several occasions where I ended up redoing code I previously wrote because I realized there was a better way to write it, which let me get a better running program that is going to be more maintainable in the longrun. 
</p>
<p></p>
<p>Provide an application of Inheritance</p>
<p></p>
<p>
For example, in the following code for the method GetReady, I wrote it once, and then used it in 3 separate cases. The private member variable _readyTime let me adjust one number, in one location so that if I wanted to change how long I gave the user to get ready to begin the activity, I could make one change, and that would update everywhere. And because I wrote that code in my parent class Activity, and then used the principle of inheritance to use the same method in each of my 3 child classes, if ever I want to make a change to my code, I just have one place where I need to make the changes. 
</p>
<code>
public void GetReady ()
    {
        Console.WriteLine ("Get Ready");
        
        PauseWithSpinner (_readyTime);

        Console.WriteLine ();
    }
</code>
