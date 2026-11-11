using System;

class Program
{
    static void Main(string[] args)
    {
        int userSelection = 0;

        while (userSelection != 4)
        {
            Console.Clear();
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("> ");

            userSelection = int.Parse(Console.ReadLine());

            switch (userSelection)
            {
                case 1:
                    BreathingActivity breathingActivity = new BreathingActivity("Breathing", "Teach you how to breathe.");
                    breathingActivity.RunActivity();
                    break;
                case 2:
                    // ReflectionActivity reflectionActivity = new ReflectionActivity();
                    break;
                case 3:
                    // ListingActivity listingActivity = new ListingActivity();
                    break;
            }
        }        
    }
}