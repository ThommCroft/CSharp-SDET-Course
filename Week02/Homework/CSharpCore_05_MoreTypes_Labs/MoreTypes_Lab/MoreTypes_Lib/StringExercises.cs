using System;
using System.Linq;

namespace MoreTypes_Lib
{
    public class StringExercises
    {
        // manipulates and returns a string - see the unit test for requirements
        public static string ManipulateString(string input, int num)
        {
            string result = input.Trim().ToUpper();

            for (int i = 0; i < num; i++)
            {
                result += i.ToString();
            }

            return result;
        }

        // returns a formatted address string given its components
        public static string Address(int number, string street, string city, string postcode)
        {
            return String.Format("{0} {1}, {2} {3}.", number, street, city, postcode);
        }

        // returns a string representing a test score, written as percentage to 1 decimal place
        public static string Scorer(int score, int outOf)
        {
            double percentage;

            percentage = score * 100f / outOf;
            percentage = Math.Round(percentage, 1);

            return String.Format("You got {0} out of {1}: {2}%", score, outOf, percentage);
        }

        // returns the double represented by the string, or -999 if conversion is not possible
        public static double ParseNum(string numString)
        {
            bool stringCheck;
            double result;

            stringCheck = !numString.Any(x => char.IsLetter(x));

            if (stringCheck)
            {
                result = Convert.ToDouble(numString);
            }
            else
            {
                result = -999;
            }

            return result;
        }

        // Returns the a string containing the count of As, Bs, Cs and Ds in the parameter string
        // all other letters are ignored
        public static string CountLetters(string input)
        {
            int aCount = 0;
            int bCount = 0;
            int cCount = 0;
            int dCount = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'A')
                {
                    aCount++;
                }
                else if (input[i] == 'B')
                {
                    bCount++;
                }
                else if (input[i] == 'C')
                {
                    cCount++;
                }
                else if (input[i] == 'D')
                {
                    dCount++;
                }
            }
            return String.Format("A:{0} B:{1} C:{2} D:{3}", aCount, bCount, cCount, dCount);
        }
    }
}
