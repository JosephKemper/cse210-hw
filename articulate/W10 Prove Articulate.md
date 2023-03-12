<p>Joseph D. Kemper</p>
<p>CSE 210-09: Programming with Classes</p>
<p>W08 Prove: Articulate</p>
<p>25 February</p>
<p></p>
<p>Polymorphism</p>
<p></p>
<p>Explain the meaning of Polymorphism</p>
<p></p>
<p>
Polymorphism is the capstone of the four pillars of Object-Oriented Programming. Simply put, Polymorphism is the process of turning one thing into another. The proper usage of Polymorphism will incorporate all of the other principles of Object-Oriented Programming into an almost magical form.  
</p>
<p></p>
<p>Highlight a benefit of Polymorphism</p>
<p></p>
<p>
Through Polymorphism, you can create one method that you then modify to fit the needs of multiple classes, letting your code become dynamic and easily shaped to fit your needs. It lets the computer do the hard work for you. It can be used to iterate through lists that have a variety of items that each need to be handled in different ways, greatly simplifying your code while increasing its usefulness. 
</p>
<p></p>
<p>Provide an application of Polymorphism</p>
<p></p>
<p>
A basic application of Polymorphism can be seen in a program that is built to calculate the area of different shapes. In the first code segment below, you define an abstract constructor that defines the shared attributes each child class uses, and then provides methods for working with private variables that in more advanced code, would let you apply controls to the usage of the data. For example a Setter SetMaxCyclingSpeed could have an if statement built into it, that would limit how high the MaxCylingSpeed variable could be set to. In the second block of code (the Square class) it builds upon the constructor partially defined in the Shape class, and adds only what is needed to finish off defining the square, then overrides the GetArea method to allow it to properly define the area of a square. Similar things can be done for essentially any shape. And this same idea can be applied to almost any Class you can build. 
</p>
<code>
public abstract class Shape{
    private string _color;
    private string _shapeName;
    public Shape (string color, string shapeName){
        _color = color;
        _shapeName = shapeName;
        }
    public string GetColor(){
        return _color;
        }
    public void SetColor (string color){
        _color = color;
        }
    public string GetName (){
        return _shapeName;
        }
    public void SetName (string name){
        _shapeName = name;
        }
    public abstract double GetArea ();
}
</code>
<code>
public class Square : Shape{
    private double _side;
    public Square (string color, string name, double side) : base (color, name){
        _side = side;
    }
    public override double GetArea(){
        return _side * _side;
    }
}
</code>
<code>
</code>