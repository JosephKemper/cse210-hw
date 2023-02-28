using System;

public class Circle : Shape
{
    private double _radius;

    public Circle (string color, string name, double radius) : base (color, name)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI*(_radius*_radius);
    }
}