

// _prompts : List<string>
// *
// GetRandomPrompt() : string
public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "What is one thing you are grateful for today?",
        "What is something you learned today?",
        "What made you happy today?",
        "What is the kindest thing someone has done for you recently?",
        "How did I see the hand of the Lord in my life today?"
    };

    public string GetRandomPrompt()
    {
        // Generate a random number between 0 and the number of prompts
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(0, _prompts.Count);
        // Return the prompt at that index
        return _prompts[index];
    }

}