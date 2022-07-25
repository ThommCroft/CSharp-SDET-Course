using System.IO;
using System.Diagnostics;

namespace Logging_Steaming_EncodingApp
{
    public class Program
    {
        private static string _currentDirectory = Directory.GetCurrentDirectory();
        private static string _path = Path.Combine(_currentDirectory, @"..\..\..\");

        static void Main(string[] args)
        {
            //FileOps(); // File Ops

            //Logging(); // Logging

            //ConditionalCompile(); // Conditionally Compiling Code

            FileStreaming(); // File and Buffer Streaming
        }

        private static void FileOps()
        {
            //Console.WriteLine("What is your name:");
            //var name = Console.ReadLine();
            //Console.WriteLine("Hello, " + name);

            var text = "Hello, World!";
            File.WriteAllText(_path + "Hello.txt", text);

            string content = File.ReadAllText(_path + "Hello.txt");
            Console.WriteLine(content);

            string[] lines = { "And after all", "Your.re my Wonderwall", "I said maybe!" };
            File.WriteAllLines(_path + "Wonderwall.txt", lines);

            string[] contentLines = File.ReadAllLines(_path + "Wonderwall.txt");

            foreach (string line in contentLines)
            {
                Console.WriteLine(line);
            }
        }

        private static void Logging()
        {
            Console.WriteLine($"This is being logged at time {DateTime.Now}");

            TextWriterTraceListener twtl = new TextWriterTraceListener(File.Create(_path + "TraceOutput.txt")); // Listens for debugging or trace output

            Trace.Listeners.Add(twtl); // Assigns the trace listener to be a listener

            int total = 0;

            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine(i);
                total += i;
                Debug.WriteLine($"Debug - The value of i is  {i}"); // USeful to find defects
                Trace.WriteLine($"Trace - The value of i is  {i}"); // Simlar to Debug - runs on seperate thread - monitor performance
            }

            Trace.Flush(); // Flushes the Output buffer and writes it to the Trace.Listener
        }

        private static void ConditionalCompile()
        {
            Console.WriteLine("Starting App");
#if DEBUG
            Console.WriteLine("This is debug code");
#endif
            Console.WriteLine("Finishing App");
        }

        private static void FileStreaming()
        {
            using (StreamWriter sw = File.AppendText(_path + "Mary.txt"))
            {
                sw.WriteLine("Mary had a little lamb.");
            }

            using (StreamReader sr = File.OpenText(_path + "Mary.txt"))
            {
                string s = "";

                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }

            //using (Stream ns = NetworkStream(clientSocketm true), bufStream = new BufferedStream(ns, 2014)) // Example
            //{
            //    // DO Something.
            //}
        }
    }
}