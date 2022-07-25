namespace FizzBuzzApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FizzBuzz(100));
        }

        public static string FizzBuzz(int num)
        {
            // Split(" ") then count Where(x => x.Contains("Fizz") // Used to count the number of Fizz appear in the number sequence.

            var result = Enumerable.Range(1, num).Select(x => x % 15 == 0 ? "FizzBuzz" : x % 5 == 0 ? "Buzz" : x % 3 == 0 ? "Fizz" : $"{x}");

            return string.Join(" ", result.ToArray());

            //List<int> numList = new List<int>();

            //for (int i = 1; i <= num; i++)
            //{
            //    numList.Add(i);
            //}

            //string result = "";

            //foreach (int number in numList)
            //{
            //    if (number % 3 == 0 && number % 5 == 0)
            //    {
            //        result += "FizzBuzz";
            //    }
            //    else if (number % 5 == 0)
            //    {
            //        result += "Buzz";
            //    }
            //    else if (number % 3 == 0)
            //    {
            //        result += "Fizz";
            //    }
            //    else
            //    {
            //        result += number.ToString();
            //    }
            //}

            //return result;
        }
    }
}