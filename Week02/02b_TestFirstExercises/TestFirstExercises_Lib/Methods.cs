using System;
using System.Collections.Generic;
using System.Linq;

namespace TestFirstExercises
{
    public class Methods
    {
        // implement this method so that it returns true if x is greater than or equal to y
        public static bool GreaterEqual(int x, int y)
        {
            if (x >= y)
            {
                return true;
            }

            return false;
        }

        // Implement this method so that it take an int as an input,
        // squares it, adds 101, divides the result by 7, then subtracts 4.  
        // Return a double rounded to 3 decimal places.
        public static double BODMAS(int inputNumber)
        {
            double result;

            //result = (((inputNumber * 2) + 101) / 7) - 4;

            result = inputNumber * 2;
            result += 101;
            result /= 7;
            result -= 4;

            result = Math.Round(result, 3);

            return result;
        }

        // implement this method so that it returns true if num is even, otherwise false
        public static bool EvenOdd(int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }

            return false;
        }

        // implement this method so that it returns 
        // the sum of all numbers between 1 and n inclusive 
        // that are divisible by either 2 or 5
        public static int SumEvenFive(int max)
        {
            if (max <= 0)
            {
                return 0;
            }

            var numberList = Enumerable.Range(1, max).ToList();

            int total = 0;

            foreach (int num in numberList)
            {
                if (num % 2 == 0 || num % 5 == 0)
                {
                    total += num;
                }
            }

            return total;
        }

        // implement this method so it returns true if input is "password"
        // regardless of case
        public static bool CheckInput(string input)
        {
            if (input.ToLower() == "password")
            {
                return true;
            }

            return false;
        }

        // implement this method so it returns the sum
        // of all the numbers in the list
        public static int SumList(List<int> list)
        {
            int total = 0;

            foreach (int num in list)
            {
                total += num;
            }

            return total;
        }
    }
}