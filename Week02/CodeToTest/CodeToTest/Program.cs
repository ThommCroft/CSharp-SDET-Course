using System;

namespace CodeToTest;

public class Program
{
    public static void Main(string[] args)
    {
        //int timeOfDay = 24;
        //var greet = Greeting(timeOfDay);
        //Console.WriteLine(greet);

        int viewerAge = 30;
        var availableClassification = AvailableClassification(viewerAge);
        Console.WriteLine(availableClassification);
    }

    public static string Greeting(int timeOfDay)
    {
        string greeting;

        if (timeOfDay < 0 || timeOfDay > 24)
        {
            greeting = "Invalid Time!";
        }
        else if (timeOfDay >= 5 && timeOfDay <= 12)
        {
            greeting = "Good Morning!";
        }
        else if (timeOfDay > 12 && timeOfDay <= 18)
        {
            greeting = "Good Afternoon!";
        }
        else
        {
            greeting = "Good Evening!";
        }

        return greeting;
    }

    public static string AvailableClassification(int ageOfViewer)
    {
        string result;

        if (ageOfViewer < 0)
        {
            result = "Error: Age not possible!";
        }
        else if (ageOfViewer < 12) // If the viewer is younger than 12
        {
            //result = "U, PG & 12 Films are available.";
            result = "U & PG Films are available.";
        }
        else if (ageOfViewer < 15) // If the viewer is younger than 15
        {
            //result = "U, PG, 12 & 15 Films are available.";
            result = "U, PG, 12A & 12 Films are available.";
        }
        else if (ageOfViewer < 18) // If the viewer is younger than 18
        {
            //result = "U, PG, 12 & 15 Films are available.";
            result = "U, PG, 12 & 15 Films are available.";
        }
        else // The viewer is aged 18+
        {
            result = "All Films are available.";
        }

        return result;
    }
}