using System;

class Program
{
    static void Main(string[] args)
    {
        string gradeString;
        Console.Write("What is your grade? (1-100) ");
        gradeString = Console.ReadLine();

        int gradeInt = int.Parse(gradeString);

        if (gradeInt >= 90)
            Console.WriteLine("You have earned an A!");
        else if (gradeInt >= 80 && gradeInt < 90)
            Console.WriteLine("You have earned a B!");
        else if (gradeInt >= 70 && gradeInt < 80)
            Console.WriteLine("You have earned a C.");
        else if (gradeInt >= 60 && gradeInt < 70)
            Console.WriteLine("You have earned a D.");
        else if (gradeInt < 60)
            Console.WriteLine("You earned an F.");

        if (gradeInt >= 70)
            Console.WriteLine("Congratulations! You passed!");
        else if (gradeInt < 70)
            Console.WriteLine("Sorry, you have failed.");
    }
}