namespace ExceptionsApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Exception Handling
            //string text;
            //string fileName = "terminator.txt";

            //try
            //{
            //    text = File.ReadAllText(fileName);
            //    Console.WriteLine(text);
            //}
            //catch (FileNotFoundException ex)
            //{
            //    Console.WriteLine("Sorry cannot find: " + fileName);
            //}

            //try
            //{
            //    Console.WriteLine("Charlie recieved 88: " + Grade(88));
            //    Console.WriteLine("Thomas recieved -100: " + Grade(-100));
            //}
            //catch (ArgumentOutOfRangeException ex)
            //{
            //    Console.WriteLine(ex.ToString());
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("I will always execute");
            //}
            #endregion

            //int anInt = 3;  // Explicite Type
            //int vInt = 3; // Implicite Type

            #region Data Types
            //decimal sum = 0;

            //for (int i = 0; i < 100_000; i++)
            //{
            //    sum += 2m / 5.0m;
            //}

            //Console.WriteLine("2/5 added 100,000 times: " + sum);
            //Console.WriteLine("2/5 multiplied 100,000: " + 2m/5.0m * 100_000);

            // ASCII
            //char n = 'N';
            //int i = n;
            //Console.WriteLine((int)n);
            //Console.WriteLine(i);

            var theInt = 5;
            var anotherInt = Convert.ToChar(theInt);

            Console.WriteLine(theInt);
            Console.WriteLine(anotherInt);
            #endregion
        }

        public static string Grade(int mark)
        {
            if (mark < 0 || mark > 100)
            {
                throw new ArgumentOutOfRangeException("Mark: " + mark + ", Allowed Range is 0 - 100");
            }

            return mark >= 65 ? (mark >= 85 ? "Distinction" : "Pass") : "Fail";
        }
    }
}