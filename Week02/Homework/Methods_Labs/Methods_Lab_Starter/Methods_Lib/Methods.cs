using System;

namespace Methods_Lib
{
    public class Methods
    {
        // implement this method so it returns a tuple (weeks, days) 
        // corresponding to a given number of days
        public static (int weeks, int days) DaysAndWeeks(int totalDays)
        {
            if (totalDays < 0)
            {
                throw new ArgumentOutOfRangeException("totalDays must not be negative");
            }

            int daysInWeek = 7;

            return (totalDays / daysInWeek, totalDays % daysInWeek);
        }

        public static (int squared, int cubed, double squareRoot) PowersRoot(int number)
        {
            int square = number * number;
            int cube = (number * number) * number;
            double sqRoot = number / number;

            return (square, cube, sqRoot);
        }

        public static int RollDice(Random rng)
        {
            var num1 = rng.Next(1, 7);
            var num2 = rng.Next(1, 7);
            return num1 + num2;
        }

    }
}
