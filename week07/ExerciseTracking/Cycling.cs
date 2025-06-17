using System;

public class Cycling : Activity
{
    private double _speed; // in km/h

    public Cycling(string date, int length, double speed) : base(date, length)
    {
        _speed = speed;
    }
    public override double GetDistance()
    {
        return (_speed * GetLength()) / 60; // Distance in km
    }
    public override double GetSpeed()
    {
        return _speed; // Speed is already in km/h
    }
    public override double GetPace()
    {
        return 60 / _speed; // Pace in min/km
    }
}