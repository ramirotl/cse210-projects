using System;

public class Activity
{
    private string _activityName;
    private string _description;
    private int _duration;

    public Activity(string activityName, string description, int duration)
    {
        _activityName = activityName;
        _description = description;
        _duration = duration;
    }
    public int GetDuration()
    {
        return _duration;
    }
    public void SetDuration(int duration)
    {
        _duration = duration;
    }
    public void DisplayStartingMessage()
    {

        Console.WriteLine($"Welcome to the {_activityName}");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        // Ask the user to enter the duration of the activity
        Console.Write("How long in seconds would you like for this session? ");

        // Read the user input
        string input = Console.ReadLine();
        int seconds;
        while (!int.TryParse(input, out seconds) || seconds <= 0)
        {
            Console.Write("Please enter a valid positive number: ");
            input = Console.ReadLine();
        }
        SetDuration(seconds);
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);


    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_activityName}.");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        List<string> spinner = new List<string> { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i]);
            Thread.Sleep(250); // pause 0.25 seconds
            Console.Write("\b \b"); // erase the last character
            i++;
            if (i >= spinner.Count)
            {
                i = 0; // reset index to loop through spinner
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b"); // 
        }
        Console.WriteLine();
    }
}