using System;
using System.Security.Cryptography.X509Certificates;

public class Breathing : Activity
{


    public Breathing(string activityName, string description, int duration) : base(activityName, description, duration)
    {

    }

    public void Run()
    {

        int totalTime = GetDuration();
        int elapsed = 0;

        while (elapsed < totalTime)
        {
            Console.WriteLine();
            Console.Write("Breathe in... ");
            ShowCountDown(3);

            Console.WriteLine();
            Console.Write("Breathe out... ");
            ShowCountDown(3);

            elapsed += 6;
        }



    }
}