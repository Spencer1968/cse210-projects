class ReflectionActivity : BaseActivity
{
    public ReflectionActivity(string name, string description) : base(description, name)
    {
    }

    private string[] _prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] _questions =
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
    };

    public void RunActivity()
    {
        // call StartActivity() method
        StartActivity();

        RunCountDownMessage("Get Ready", 5);
        StartTimer();
        Console.Write(_prompts[Random.Shared.Next(_prompts.Length)]);
        RunSpinnerMessage("", 6);
        Console.WriteLine();

        while (! HasTimerExpired()) // Add when code is ready
        {
            Console.Write(_questions[Random.Shared.Next(_questions.Length)]);
            RunSpinnerMessage("", 8);
            Console.WriteLine();
        }

        // Call EndActivity()
        EndActivity();
    }
}