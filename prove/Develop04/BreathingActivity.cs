class BreathingActivity : BaseActivity
{
    public BreathingActivity(string name, string description) : base()
    {
    }
    public void RunActivity()
    {
        // call StartActivity() method

        RunCountDownMessage("Get Ready", 5);
        StartTimer();
        while (! HasTimerExpired()) // Add when code is ready
        {
            RunCountDownMessage("Breath In", 4);
            RunCountDownMessage("Breath Out", 6);
        }

        // Call EndActivity()
    }
}