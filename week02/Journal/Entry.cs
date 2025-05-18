

// _date : string
// _promptText : string
// _entryText : string
// *
// Display() : void
public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        // Display the entry details
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine(); // Blank line for spacing
    }
}