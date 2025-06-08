using System;

public class Listing : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();
    public Listing(string activityName, string description, int duration) : base(activityName, description, duration)

    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");

    }

    public string GetRandomPrompt() //void???
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index]; //????
    }

    public List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            items.Add(item);
        }

        return items;
    }

    public void Run()
    {
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");

        Console.Write("You may begin in: ");
        ShowCountDown(5); // Countdown before starting the listing

        List<string> userItems = GetListFromUser();

        _count = userItems.Count;
        Console.WriteLine($"You listed {_count} items!");

    }
}

