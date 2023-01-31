using System;

public class Fraction
{
    private int _numerator;
    private int _denominator;

    public void AFraction ()
    {
        _numerator = 1;
        _denominator = 1;
    }
    
    public void AFraction (int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }

    public void AFraction (int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    public string GetFractionString()
    {
        string stringFraction = $"{_numerator}/{_denominator}";
        return stringFraction;
    }

// TODO #14 BUG GetDecimalValue not properly converting to lower than 1
    public double GetDecimalValue()
    {
        return (double) _numerator/(double)_denominator;
    }
}