using System;

public class Video
{
    public string _title;
    public string _author;
    public int _length; // in seconds
    public List<Comment> _comments = new List<Comment>();

    public Video(string videoTitle, string videoAuthor, int videoLength)
    {
        _title = videoTitle;
        _author = videoAuthor;
        _length = videoLength;
        // _comments = new List<Comment>();
    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }
    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Number of comments: {GetNumberOfComments()}");
        foreach (var comment in _comments)
        {
            comment.DisplayComment();
        }
        Console.WriteLine(); // Blank space
    }
}