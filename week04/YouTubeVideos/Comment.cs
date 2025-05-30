using System;

public class Comment
{
    public string _name;
    public string _text;

    public Comment(string nameViewer, string textComment)
    {
        _name = nameViewer;
        _text = textComment;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"{_name} commented: {_text}");
    }
}