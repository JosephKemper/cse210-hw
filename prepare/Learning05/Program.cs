using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");
        Square testSquare = new Square("Brown","Square", 4);
        Console.WriteLine (testSquare.GetColor());
        Console.WriteLine (testSquare.GetArea());
        Console.WriteLine (testSquare.GetName());

        Console.WriteLine ();

        Rectangle testRectangle = new Rectangle ("Blue","Rectangle", 4, 5);
        Console.WriteLine (testRectangle.GetColor());
        Console.WriteLine (testRectangle.GetArea());
        Console.WriteLine (testRectangle.GetName());

        Console.WriteLine ();

        Circle testCircle = new Circle ("Green","Circle", 7);
        Console.WriteLine (testCircle.GetColor());
        Console.WriteLine (testCircle.GetArea());
        Console.WriteLine (testCircle.GetName());

        Console.WriteLine ();

        List<Shape> shapesList = new List<Shape> ();
        shapesList.Add (testCircle);
        shapesList.Add (testRectangle);
        shapesList.Add (testSquare);

        foreach (Shape shape in shapesList)
        {
            double area = shape.GetArea ();
            string color = shape.GetColor ();
            string name = shape.GetName ();
            Console.WriteLine ($"The shape {shape}, is colored {color}, and has an area of {area}.");
        }
        }

}