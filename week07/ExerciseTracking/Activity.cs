using System;

public abstract class Activity
{
    private string _date;
    private int _length; // in minutes

    public Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }

    public string GetDate()
    {
        return _date;
    }
    public int GetLength()
    {
        return _length;
    }

    //abstract methods

    public abstract double GetDistance();
    public abstract double GetSpeed(); // in km/h
    public abstract double GetPace(); // in min/km

    public virtual string GetSummary()
    {   // use this.GetType().Name to get the type of the activity
        return $"{_date} {this.GetType().Name} ({_length} min) - Distance: {GetDistance()} km, Speed: {GetSpeed()} km/h, Pace: {GetPace()} min per km";
    }
}