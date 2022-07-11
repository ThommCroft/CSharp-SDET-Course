using System;

namespace MoreTypes_Lib
{
    public enum Suit
    {
        HEARTS, CLUBS, DIAMONDS, SPADES
    }

    public class DateTimeEnumsExercises
    {
        // returns a person's age at a given date, given their birth date.
        public static int AgeAt(DateTime birthDate, DateTime date)
        {
            if (birthDate > date)
            {
                throw new ArgumentException("Error - birthDate is in the future");
            }
            
            int age = 0;

            if (birthDate.Month > date.Month)
            {
                age = (date.Year - birthDate.Year) - 1;
            }
            else
            {
                age = date.Year - birthDate.Year;
            }

            return age;
        }

        // returns a date formatted in the manner specified by the unit test
        public static string FormatDate(DateTime date)
        {
            return date.ToString("yy/dd/MMM");
        }

        // returns the name of the month corresponding to a given date
        public static string GetMonthString(DateTime date)
        {
            return date.ToString("MMMM");
        }

        // see unit tests for requirements
        public static string Fortune(Suit suit)
        {
            string message = "";

            switch (suit)
            {
                case Suit.CLUBS:
                    message = "And the seventh rule is if this is your first night at fight club, you have to fight.";
                    break;
                case Suit.DIAMONDS:
                    message = "Diamonds are a girls best friend";
                    break;
                case Suit.HEARTS:
                    message = "You've broken my heart";
                    break;
                case Suit.SPADES:
                    message = "Bucket and spade";
                    break;
            }

            return message;
        }
    }
}
