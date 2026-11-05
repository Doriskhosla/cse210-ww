public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "What was the best part of your day?",
        "What are you grateful for today?",
        "Describe a challenge you faced today and how you overcame it.",
        "What was the strongest emotion you felt today and why?",
        "How did I see the hand of the Lord in my life today?",
        "What was the most interesting thing I learned today?",
        "What is something that made you smile today?",
         "If I had one thing I could do over today, what would it be?"
    };
    private Random _random = new Random();

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}