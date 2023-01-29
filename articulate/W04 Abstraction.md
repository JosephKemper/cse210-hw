<p>Joseph D. Kemper</p>
<p>CSE 210-09: Programming with Classes</p>
<p>W04 Prove: Articulate</p>
<p>28 January 2023</p>
<p></p>
<p>Abstraction</p>
<p></p>
<p>Explain the meaning of Abstraction</p>
<p></p>
<p>
Abstraction to me, is a lot like planning. You simplify a complex idea and break it down into easily manageable steps. For example, if I wanted to write a program to write a journal, I would need to take that broad and complex idea, which I might add, could seem deceptively simple, and truly simplify it.
</p>
<p></p>
<p>
Highlight a benefit of Abstraction
</p>
<p></p>
<p>
A reasonable sized computer program can easily be a hundred times more complex to build than it would be to build your average house. No sane person I know, would ever consider building a house without first getting a plan (called a blueprint). Abstraction, lets you build a plan for a program, a blueprint of sorts for what you plan on doing. Through Abstraction, you can get a clearer idea of what you are trying to accomplish, and what you need to accomplish it.
</p>
<p></p>
<p>Provide an application of Abstraction</p>
<p></p>
<p>
Going back to the idea of abstracting a journal, first, you need to stop and think about what features you would need in a journal. Obviously, the ability to write a journal entry, save your journal, load up your prior journal, and exit the program. If you want to add a prompt to help the user of your program to get started on their journal, then you will need to add something to generate the prompts as well. Abstracting it out, you would have one class for your journal, that would have four methods, one to write the journal with, one to save the journal to a file, one to load the journal from a file, and one to display the journal to let the user see what they wrote. To store the journal, you will need to create a data type to be able to conveniently organize each journal entry with, and not have to store each element in separate variables. To do that, you may write something like this:</p>
<code>
public class JournalEntry
{
    public string _journalPrompt;
    public string _journalText;
    public string _currentDate;
    public void DisplayEntry()
    {
        Console.WriteLine ($"{_currentDate}");
        Console.WriteLine ($"Prompt {_journalPrompt}");
        Console.WriteLine (_journalText);
        Console.WriteLine();
        Console.WriteLine ("Press any key to continue ...");
        Console.WriteLine();
        Console.ReadKey();
    }
}
</code>
<p>
The process of abstraction would begin before writing the code, and would end with what you might use as notes to guide the writing of your program with, and in this case, would look something like this. 
</p>
<code>
// Class JournalEntry to establish data type for journal storage
// _journalPrompt member variable for storing the prompts for each journal entry
// _journalText member variable for storing the text of each journal entry
// _currentDate member variable for storing the date each journal was written
// DisplayEntry class method teaches computer how to display the entry to user
// Automatically pause after displaying each entry to allow the user a chance to read it
</code>
<p>
From there, you would write out your code, and would do the same thing with each part of the program you are going to write, so in this case, you would do the same thing for the journal prompt, and journal classes, along with the main class of the program. 
<p>