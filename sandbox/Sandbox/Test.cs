using System;
using System.Globalization;

class Program
{
    static public double sortNumbers(List<double> numbers)
    {
        double smallest = 100;
        foreach (double number in numbers)
        {
            if (number < smallest)
            {
                smallest = number;
            }
        }
        return smallest;
    }
    static void Main(string[] args)
    {
        List<double> sprintTimes = new List<double> {10, 5, 4, 13, 6};

        double smallest = sortNumbers(sprintTimes);
        Console.WriteLine("100 Meter Dash Times");
        Console.WriteLine($"{sprintTimes}");
        Console.WriteLine($"Fastest time: {smallest}.");
    }
}