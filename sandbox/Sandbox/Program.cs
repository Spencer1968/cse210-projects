using System;

class Program
{
    static void Main(string[] args)
    {
        int x = 20;
        int y = 30;
        int z = 40;

        if (x == 10 && y == 30 || z == 30) {
            Console.WriteLine("X is 10");
            Console.WriteLine("Y is fun");
        }
        else if (x == 20)
        {
            Console.WriteLine("X is 20");
        }
        else
        {
            Console.WriteLine("Default output");
        }
    }
}