using System;

// Class: Job
// Attributes: 
// * _company : string
// * _jobTitle : string
// * _startYear : int
// * _endYear : int

// Behaviors:
// * Display () : void

// Creating the class Job
public class Job
{
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear = 0;
    public int _endYear = 0;


    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }


}