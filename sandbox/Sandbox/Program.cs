using System;

class Program
{
    static void Main(string[] args)
    {
        // int x = 20;
        // int y = 30;
        // int z = 40;

        // if (x == 10 && y == 30 || z == 30) {
        //     Console.WriteLine("X is 10");
        //     Console.WriteLine("Y is fun");
        // }
        // else if (x == 20)
        // {
        //     Console.WriteLine("X is 20");
        // }
        // else
        // {
        //     Console.WriteLine("Default output");
        // }
        // bool done = false;
        // while (! done)
        // {
        //     Console.Write("Are we done (y/n)? ");
        //     done = Console.ReadLine() == "y";
        // }

        // bool done;
        
        // do
        // {
        //     Console.Write("Are we done (y/n)? ");
        //     done = Console.ReadLine().ToLower() == "y";
        // } while (! done);

        // for(double i = 0; i < 1.0; i += 0.01)
        // {
        //     Console.WriteLine(i);
        // }

        // List<string> myFriends = new List<string> {"Bob", "Betty", "Bubba"};

        // myFriends.Add("Doug");

        // foreach(string friend in myFriends)
        // {
        //     Console.WriteLine(friend);
        // }

        string heightString;
        Console.Write("Enter your height in inches: ");
        heightString = Console.ReadLine();

        int heightInt = int.Parse(heightString);

        if (heightInt < 48)
        {
            Console.WriteLine("You are too short!");
        }
        else if (heightInt > 78)
        {
            Console.WriteLine("You are too tall!");
        }
    }
}