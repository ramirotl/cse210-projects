using System.IO;

// _entries : List<Entry> 
// *
// AddEntry(newEntry : Entry) : void
// DisplayAll() : void
// SaveToFile(file : string) : void
// LoadFromFile(file : string) : void

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        // Display all entries in the journal
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }

    }
    public void SaveToFile(string file)
    {
        // Open the file for writing
        using (StreamWriter writer = new StreamWriter(file))
        {
            // Loop through each entry and write to the file
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
    }
    public void LoadFromFile(string file)
    {
        // Check if the file exists
        if (File.Exists(file))
        {
            // Read all lines from the file
            string[] lines = File.ReadAllLines(file);

            // Clear existing entries
            _entries.Clear();

            // Loop through each line and create an Entry object
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    Entry entry = new Entry();
                    entry._date = parts[0];
                    entry._promptText = parts[1];
                    entry._entryText = parts[2];
                    _entries.Add(entry);
                }
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}