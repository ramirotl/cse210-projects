using System;

public abstract class Shape
{
    private string _color;

    public Shape(string color)
    {
        _color = color;
    }
    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string color)
    {
        _color = color;
    }

    // virtual public double GetArea()
    // {
    //     return 0.0; // Default implementation, can be overridden
    // }

    public abstract double GetArea(); // Abstract method to be implemented by derived classes
}