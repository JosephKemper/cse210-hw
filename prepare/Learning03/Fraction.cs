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

    public double GetDecimalValue()
    {
        return _numerator/_denominator;
    }
}