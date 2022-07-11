namespace ControlFlowApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Ternary Operators
            //int mark = 65;

            //string grade = mark >= 65 ? "Pass" : "Fail";
            //Console.WriteLine(grade);

            //string secondGrade = mark >= 65 ? (mark >= 85 ? "Distinction" : "Pass") : (mark < 20 ? "Failed no retake" : "Fail with retake");
            //Console.WriteLine(secondGrade);
            #endregion

            //Console.WriteLine(Priority(1));
            //Console.WriteLine(DrivingLawsExample1(18));
            //Console.WriteLine(DrivingLawsExample2(18));

            #region Loops
            List<int> nums = new List<int> { 10, 6, 22, -17, 3 };
            Console.WriteLine("Highest foreach loop: " + LoopTypes.HighestForEachLoop(nums));
            Console.WriteLine("Highest for- loop: " + LoopTypes.HighestForLoop(nums));
            Console.WriteLine("Highest while- loop: " + LoopTypes.HighestWhileLoop(nums));
            Console.WriteLine("Highest do-while loop: " + LoopTypes.HighestDoWhileLoop(nums));
            #endregion
        }

        public static string Grade(int mark)
        {
            return mark >= 65 ? (mark >= 85 ? "Distinction" : "Pass") : "Fail";
        }

        #region Switch Statements
        public static string Priority(int level)
        {
            string priority = "Code ";

            switch (level)
            {
                case 3:
                    priority = priority + "Red";
                    break;
                case 2:
                case 1:
                    priority = priority + "Amber";
                    break;
                case 0:
                    priority = priority + "Green";
                    break;
                default:
                    priority = "Error";
                    break;
            }

            return priority;
        }

        public static string DrivingLawsExample1(int age)
        {
            string law = "";

            switch (age)
            {
                case int when (age < 18):
                    law = "Cannot Legally Drive";
                    break;
                case int when (age >= 18 && age < 23):
                    law = "Can Legally Drive but cannot hire a car";
                    break;
                case int when (age >= 23):
                    law = "Can Legally Drive and hire a car";
                    break;
                default:
                    law = "Unknown Law";
                    break;
            }

            return law;
        }

        public static string DrivingLawsExample2(int age)
        {
            string law = "";

            switch (age)
            {
                case < 18:
                    law = "Cannot Legally Drive";
                    break;
                case < 23:
                    law = "Can Legally Drive but cannot hire a car";
                    break;
                default:
                    law = "Can Legally Drive and hire a car";
                    break;
            }

            return law;
        }
        #endregion
    }
}