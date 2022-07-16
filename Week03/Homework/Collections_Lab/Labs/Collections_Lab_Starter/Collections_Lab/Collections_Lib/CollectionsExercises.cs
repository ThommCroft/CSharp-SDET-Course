using System;
using System.Collections.Generic;

namespace Collections_Lib
{
    public class CollectionsExercises
    {
        /* removes and returns the next num entries in the queue, as a comma separated string */
        public static string NextInQueue(int num, Queue<string> queue)
        {
            List<string> resultList = new List<string>();

            for (int i = 0; i < num; i++)
            {
                if (queue.TryDequeue(out string result))
                {
                    resultList.Add(result);
                }
            }

            return String.Join(", ", resultList);
        }

        /* uses a Stack to create and return array of ints in reverse order to the one supplied */
        public static int[] Reverse(int[] original)
        {
            Stack<int> stack = new Stack<int>();

            for (int i = original.GetLowerBound(0); i <= original.GetUpperBound(0); i++)
            {
                stack.Push(original[i]);
            }

            return stack.ToArray();
        }

        // using a Dictionary, counts and returns (as a string) the occurence of the digits 0-9 in the given string
        public static string CountDigits(string input)
        {
            Dictionary<char, int> numbersDictionary = new Dictionary<char, int>();

            string result = "";

            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    if (numbersDictionary.ContainsKey(c))
                    {
                        numbersDictionary[c]++;
                    }
                    else
                    {
                        numbersDictionary.Add(c, 1);
                    }
                }
            }

            foreach (KeyValuePair<char, int> kvp in numbersDictionary)
            {
                result += kvp;
            }

            return result;
        }
    }
}
