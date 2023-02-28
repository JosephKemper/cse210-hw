using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");
        Square testSquare = new Square("Brown", 4);
        Console.WriteLine (testSquare.GetColor());
        Console.WriteLine (testSquare.GetArea());

        Console.WriteLine ();

        Rectangle testRectangle = new Rectangle ("Blue", 4, 5);
        Console.WriteLine (testRectangle.GetColor());
        Console.WriteLine (testRectangle.GetArea());

        Console.WriteLine ();

        Circle testCircle = new Circle ("Green", 7);
        Console.WriteLine (testCircle.GetColor());
        Console.WriteLine (testCircle.GetArea());

        Console.WriteLine ();

        List<Shape> shapesList = new List<Shape> ();
        shapesList.Add (testCircle);
        shapesList.Add (testRectangle);
        shapesList.Add (testSquare);

        foreach (Shape shape in shapesList)
        {
            Console.WriteLine (shape.GetColor());
            Console.WriteLine (shape.GetArea());
        }
        }

}