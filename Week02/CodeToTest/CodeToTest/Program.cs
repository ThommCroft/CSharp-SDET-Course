using System;

namespace CodeToTest;

public class Program
{
    public static void Main(string[] args)
    {
        int timeOfDay = 21;

        var greet = Greeting(timeOfDay);

        Console.WriteLine(greet);
    }

    public static string Greeting(int timeOfDay)
    {
        string greeting;

        if (timeOfDay >= 5 && timeOfDay <= 12)
        {
            greeting = "Good Morning!";
        }
        else if (timeOfDay >= 12 && timeOfDay <= 18)
        {
            greeting = "Good Afternoon!";
        }
        else
        {
            greeting = "Good Evening!";
        }

        return greeting;
    }
}