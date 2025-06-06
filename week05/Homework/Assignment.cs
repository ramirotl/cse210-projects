using System;
public class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }
    public string GetStudentName() // getter for _studentName in WritingAssignment.cs and MathAssignment.cs
    {
        return _studentName;
    }
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}