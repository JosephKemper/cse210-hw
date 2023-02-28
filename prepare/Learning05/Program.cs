using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");
        Square testSquare = new Square("Brown", 4);
        Console.WriteLine (testSquare.GetColor());
        Console.WriteLine (testSquare.GetArea());
    }
}