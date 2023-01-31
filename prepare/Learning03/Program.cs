using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        Fraction testFraction = new Fraction();
        testFraction.AFraction();
        string writeFraction = testFraction.GetFractionString();
        double convertFraction = testFraction.GetDecimalValue();
        Console.WriteLine ($"The fraction is {writeFraction}");
        Console.WriteLine ($"In decimal form that is {convertFraction}");

        
    }
}