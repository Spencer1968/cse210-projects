class BreathingActivity : BaseActivity
{
    public BreathingActivity(string name, string description) : base(description, name)
    {
    }
    public void RunActivity()
    {
        // call StartActivity() method
        StartActivity();

        RunCountDownMessage("Get Ready", 5);
        StartTimer();
        while (! HasTimerExpired()) // Add when code is ready
        {
            RunCountDownMessage("Breath In", 4);
            RunCountDownMessage("Breath Out", 6);
        }

        // Call EndActivity()
        EndActivity();
    }
}