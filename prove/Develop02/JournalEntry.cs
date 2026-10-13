using System.Configuration.Assemblies;

class JournalEntry
{
    public string _date;
    public string _prompt;
    public string _response;

    public void DisplayJournalEntry()
    {
        Console.WriteLine($"Date: {_date}, {_prompt}\b");
        Console.WriteLine($"{_response}\b");
        Console.WriteLine("");
    }

    public void CreateJournalEntry()
    {
        string [] prompts =
        {
            "How was your day?",
            "Talk about someone you met.",
            "Who was the most interesting person you interacted with today?",
            "How did you see the hand of the Lord in my life today?",
            "What was the strongest emotion you felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What is one thing that you are grateful for today?",
            "Who is your inspiration recently?",
        };
        _date = DateTime.Now.ToShortDateString();
        int randomIndex = Random.Shared.Next(prompts.Length);
        _prompt = prompts[randomIndex];
        Console.WriteLine($"{_prompt} ");
        Console.Write("> ");
        _response = Console.ReadLine();
    }

    public void CreateJournalEntry(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }

        public string CreateFileSystemString()
    {
        string outputString = "";
        outputString = $"{_date}#{_prompt}#{_response}";

        return outputString;
    }
}