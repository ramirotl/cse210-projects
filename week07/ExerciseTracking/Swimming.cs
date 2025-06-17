using System;

public class Swimming : Activity
{
    private double _laps;

    public Swimming(string date, int length, double laps) : base(date, length)
    {
        _laps = laps;
    }
    public override double GetDistance()
    {
        return _laps * 50 / 1000; // Assuming each lap is 50 meters, convert to km
    }
    public override double GetSpeed()
    {
        return (GetDistance() / GetLength()) * 60; // Speed in km/h
    }
    public override double GetPace()
    {
        return GetLength() / GetDistance(); // Pace in min/km
    }

}