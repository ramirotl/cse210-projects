
// track of the reference and text of the scripture
// hide words and get the rendered display of the text
public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        // Split the text into words and create Word objects for each word
        // using the Word class
        string[] parts = text.Split(" ");
        foreach (string part in parts)
        {
            _words.Add(new Word(part));
        }

    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int count = _words.Count;

        for (int i = 0; i < numberToHide; i++)
        {
            int index = random.Next(0, count);
            _words[index].Hide();

        }
    }
    public string GetDisplayText()
    {
        string referenceText = _reference.GetDisplayText();
        List<string> displayedWords = new List<string>();
        foreach (Word word in _words)
        {
            displayedWords.Add(word.GetDisplayText());
        }
        return $"{referenceText} {string.Join(" ", displayedWords)}";
    }
    public bool IsCompletelyHiden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false; // if any word is not hidden, return false
            }
        }
        return true; // all words are hidden
    }
}