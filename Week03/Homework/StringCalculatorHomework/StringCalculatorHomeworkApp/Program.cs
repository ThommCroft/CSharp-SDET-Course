namespace StringCalculatorHomeworkApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add("1,2"));
        }

        public static int Add(string number)
        {
            if (number == "")
            {
                return 0;
            }

            string[] numberArr = new string[number.Length];

            //string newNumber = number.Replace(';', '3');

            numberArr = number.Split(','); // Cannot use Split().

            int result = 0;

            for (int i = 0; i < numberArr.Length; i++)
            {
                result += Convert.ToInt32(numberArr[i]);
            }

            return result;
        }
    }
}