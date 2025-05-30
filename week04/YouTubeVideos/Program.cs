using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Video video1 = new Video("How to cook lasagna", "Fernanfloo", 300); // Creating video objects
        Video video2 = new Video("Top 5 funny cats", "PewDiePie", 120);
        Video video3 = new Video("Fitness tips for beginners", "MrBeast", 240);

        video1.AddComment(new Comment("Alice01", "Great recipe")); // Adding comments to the videos
        video1.AddComment(new Comment("Bob123", "I love lasagna!"));
        video1.AddComment(new Comment("TheCharlie", "My mom cooks better than you"));

        video2.AddComment(new Comment("CatLover89", "Cats are the best!"));
        video2.AddComment(new Comment("BillieEilishFan", "Meow, meow, meow, meoow"));
        video2.AddComment(new Comment("Bob", "LOL, that orange cat is hilarious!"));

        video3.AddComment(new Comment("FitnessFanatic", "I need to start working out"));
        video3.AddComment(new Comment("GymBro66", "Leg day is the best day!"));
        video3.AddComment(new Comment("HealthyLily", "Great tips, thanks for sharing"));

        videos.Add(video1); //Adding videos to the list
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos) // Displaying video information
        {
            video.DisplayVideoInfo();
        }
    }

}