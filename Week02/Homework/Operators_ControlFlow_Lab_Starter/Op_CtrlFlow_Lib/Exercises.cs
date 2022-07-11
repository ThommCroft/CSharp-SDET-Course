using System.Collections.Generic;
using System.Linq;

namespace Op_CtrlFlow
{
    public class Exercises
    {
        public static bool MyMethod(int num1, int num2)
        {
            // if both numbers are Equal return false, else if not Equal, workout the Modulus;
            // if the Modulus has a remainder return false else return true.

            return num1 == num2 ? false : (num1 % num2) == 0;
        }

        // returns the average of the array nums
        public static double Average(List<int> nums)
        {
            double average = 0.0;

            return average = nums.Count > 0 ? nums.Average() : 0.0;
        }

        // returns the type of ticket a customer is eligible for based on their age
        // "Standard" if they are between 18 and 59 inclusive
        // "OAP" if they are 60 or over
        // "Student" if they are 13-17 inclusive
        // "Child" if they are 5-12
        // "Free" if they are under 5
        public static string TicketType(int age)
        {
            string ticketType = string.Empty;

            if (age >= 60)
            {
                ticketType = "OAP";
            }
            else if (age >= 18 && age <= 59)
            {
                ticketType = "Standard";
            }
            else if (age >= 13 && age <= 17)
            {
                ticketType = "Student";
            }
            else if (age >= 5 && age <= 12)
            {
                ticketType = "Child";
            }
            else if (age >= 0 && age <= 4)
            {
                ticketType = "Free";
            }

            return ticketType;
        }

        public static string Grade(int mark)
        {
            var grade = "";

            if (mark >= 75)
            {
                grade = "Pass with Distinction";
            }
            else if (mark >= 60 && mark <= 74)
            {
                grade = "Pass with Merit";
            }
            else if (mark >= 40 && mark <= 59)
            {
                grade = "Pass";
            }
            else if (mark >= 0 && mark <= 39)
            {
                grade = "Fail";
            }

            return grade;
        }

        public static int GetScottishMaxWeddingNumbers(int covidLevel)
        {
            int maxAttendees = 0;

            switch (covidLevel)
            {
                case 4:
                    maxAttendees = 20;
                    break;
                case 3:
                case 2:
                    maxAttendees = 50;
                    break;
                case 1:
                    maxAttendees = 100;
                    break;
                case 0:
                    maxAttendees = 200;
                    break;
            }

            return maxAttendees;
        }
    }
}
