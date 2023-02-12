<p>Joseph D. Kemper</p>
<p>CSE 210-09: Programming with Classes</p>
<p>W04 Prove: Articulate</p>
<p>11 February</p>
<p></p>
<p>Encapsulation</p>
<p></p>
<p>Explain the meaning of Encapsulation</p>
<p></p>
<p>
Encapsulation is the practice of restricting access to different parts of the program. One way this is done, is through marking member variables as private, which in turn prevents them from being accessed outside of the class. 
</p>
<p></p>
<p>Highlight a benefit of Encapsulation</p>
<p></p>
<p>
One of the major benefits of encapsulation is that you protect your program from accidental changes and the resulting bugs that can come from those accidental changes, which could become extremely common with larger projects that are being worked on by a team of programmers. 
</p>
<p></p>
<p>Provide an application of Encapsulation</p>
<p></p>
<p>
In C# when declaring member variables for classes, you can just declare them like you would in any other part of your code like this
</p>
<code>
string _currentReference;
</code>
<p>
You can also add a public tag, to make the variable useable outside of the individual class. 
</p>
<code>
public string _currentReference;
</code>
<p>
However, if you use the private tag when declaring the variable you restrict access to that member variable to just inside the specific class. 
<p>
<code>
private string _currentReference;
</code>