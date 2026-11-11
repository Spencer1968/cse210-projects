class ListingActivity : BaseActivity
{
    string[] prompts = {
        "Who are the people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(string name, string description) : base(description, name)
    {
    }

    public void RunActivity()
    {
        // call StartActivity() method
        StartActivity();

        int counter = 0;

        RunCountDownMessage("Get Ready", 5);
        StartTimer();
        Console.WriteLine("List as many responses as you can to the following prompt: ");
        Console.WriteLine(prompts[Random.Shared.Next(prompts.Length)]);

        while (! HasTimerExpired()) // Add when code is ready
        {
            Console.Write("> ");
            Console.ReadLine();
            counter++;
        }

        Console.WriteLine($"Congratulation! You just listed {counter} items!");

        // Call EndActivity()
        EndActivity();
    }
}