namespace OperatorsApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            //ExampleMethod();

            //int j = 5, k = 3, m = 4;

            //m += +j++ + ++k;

            //Console.WriteLine("J: " + j);
            //Console.WriteLine("K: " + k);
            //Console.WriteLine("M: " + m);


            //int a = 10 % 11;

            //Console.WriteLine(a);

            #region Logical Operators
            bool isWearingParachute = false;

            if (isWearingParachute || JumpOutOfPlane())
            {
                Console.WriteLine("Congrats, you have made a successful jump!");
            }

            string greeting = "Hello";

            if (greeting != null && greeting.ToLower().StartsWith('h'))
            {
                Console.WriteLine($"{greeting} starts with an 'h'");
            }

            int n = 0;
            int o = 3;

            if (n == 5 ^ o == 3) // Only one condition needs to be true for this to run.
            {
                Console.WriteLine("Bitwise Exclusive or");
            }
            #endregion

            #region Selection

            #endregion
        }

        private static void ExampleMethod()
        {
            const int NUM_COLS = 5;
            const int NUM_ROWS = 2;

            bool running = true;
            int row = 0;
            int col = 0;
            int spriteNumber = -1;

            while (running)
            {
                spriteNumber = ++spriteNumber % (NUM_ROWS * NUM_COLS);

                row = spriteNumber / NUM_COLS;
                col = spriteNumber % NUM_COLS;
            }
        }

        public static bool JumpOutOfPlane()
        {
            Console.WriteLine("Jump");
            return true;
        }
    }
}