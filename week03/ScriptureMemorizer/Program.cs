using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        string text = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, text);

        while (!scripture.IsCompletelyHiden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to hide more words or type 'quit' to finish");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }
            scripture.HideRandomWords(3);

        }
    }
}