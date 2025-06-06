using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Samuel Jackson", "Multiplication");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment assignment1 = new MathAssignment("Pedro Alcachofa", "Fractions", "Section 7.3", "Problems 8-9");
        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine(assignment1.GetHomeworkList());

        WritingAssignment assignment2 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetWritingInformation());
    }
}