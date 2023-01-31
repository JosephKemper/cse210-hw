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

        testFraction.AFraction(5);
        writeFraction = testFraction.GetFractionString();
        convertFraction = testFraction.GetDecimalValue();
        Console.WriteLine ($"The fraction is {writeFraction}");
        Console.WriteLine ($"In decimal form that is {convertFraction}");

        testFraction.AFraction (3,4);
        writeFraction = testFraction.GetFractionString();
        convertFraction = testFraction.GetDecimalValue();
        Console.WriteLine ($"The fraction is {writeFraction}");
        Console.WriteLine ($"In decimal form that is {convertFraction}");

        testFraction.AFraction (1,3);
        writeFraction = testFraction.GetFractionString();
        convertFraction = testFraction.GetDecimalValue();
        Console.WriteLine ($"The fraction is {writeFraction}");
        Console.WriteLine ($"In decimal form that is {convertFraction}");
    }
}