using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running run = new Running("10 Jun 2025", 30, 5.0);
        Cycling cycle = new Cycling("11 Jun 2025", 45, 20.0);
        Swimming swim = new Swimming("12 Jun 2025", 60, 40.0);

        activities.Add(run);
        activities.Add(cycle);
        activities.Add(swim);
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }

    }
}