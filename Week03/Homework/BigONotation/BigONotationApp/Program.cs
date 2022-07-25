namespace BigONotationApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(SumLoop(100));

            //Console.WriteLine(SumRecursive(5)); // Step A.

            Console.WriteLine(FactorialRecursive(5));
        }

        public static int SumLoop(int n)
        {
            int sum = 0;

            for (int i = 0; i <= n; i++)
            {
                sum += i;
            }

            return sum;
        }

        public static int SumRecursive(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            int prev = SumRecursive(n - 1); // Step B.

            int sum = n + prev;

            return sum;
        }

        // Factorial is a number times by all numbers to down to 1.
        public static int FactorialRecursive(int n)
        {
            if (n < 1 || n > 21)
            {
                throw new ArgumentOutOfRangeException("n has to between 1 and 21");
            }

            if (n == 1)
            {
                return 1;
            }

            int newNum = FactorialRecursive(n - 1);

            int sum = n * newNum;

            return sum;
        }
    }
}