class BaseActivity
{
    private int _duration;
    private DateTime _endTime;
    private string _startingMessage;

    private string _name;
    public BaseActivity(string startingMessage, string name)
    {
        _startingMessage = startingMessage;
        _name = name;
        _duration = 0;
    }

    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to {_name.ToUpper()} Activity.");
        Console.WriteLine($"{_startingMessage}");
        Console.Write("How long, in seconds, would you like this activity to last? ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void EndActivity()
    {
        RunSpinnerMessage("Well done...", 5);
        Console.WriteLine();
        RunSpinnerMessage($"You just completed {_name} activity for {_duration} seconds.", 5);
    }

    public void StartTimer()
    {
        _endTime = DateTime.Now.AddSeconds(_duration);
    }

    public bool HasTimerExpired()
    {
        return DateTime.Now > _endTime;
    }

    public void RunCountDownMessage(string message, int seconds)
    {
        Console.CursorVisible = false;
        for (int i = seconds; i > 0; i--)
        {
            Console.Clear();
            Console.WriteLine($"{message} - {i}");
            Thread.Sleep(1000);
        }
        Console.CursorVisible = true;
    }

    public void RunSpinnerMessage(string message, int seconds)
    {
        Console.CursorVisible = false;
        // DateTime now = DateTime.Now;
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        // for (int i = 0; i < seconds; i++)
        Console.Write(message);
        while (DateTime.Now < endTime)
        {
            Console.Write("-");
            Thread.Sleep(200);
            Console.Write("\b");
            Console.Write("\\");
            Thread.Sleep(200);
            Console.Write("\b");
            Console.Write("|");
            Thread.Sleep(200);
            Console.Write("\b");
            Console.Write("/");
            Thread.Sleep(200);
            Console.Write("\b");
        }
        Console.CursorVisible = true;
    }
}