using System;

class Program
{
    static void Main(string[] args)
    {
        SimpleGoal mySimpleGoal = new SimpleGoal();
        Console.WriteLine(mySimpleGoal.GetConsoleString());
        Console.WriteLine(mySimpleGoal.MarkComplete());
        Console.WriteLine(mySimpleGoal.GetConsoleString());
    }
}