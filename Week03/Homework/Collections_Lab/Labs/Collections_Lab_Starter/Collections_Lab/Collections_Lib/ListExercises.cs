using System;
using System.Collections.Generic;
using System.Linq;

namespace Collections_Lib
{
    public class ListExercises
    {
        // returns a list of all the integers between 1 to max inclusive
        // that are multiples of 5
        public static List<int> MakeFiveList(int max)
        {
            List<int> numberList = new List<int>();

            for (int i = 1; i < max + 1; i++)
            {
                if (i % 5 == 0)
                {
                    numberList.Add(i);
                }
            }
            
            return numberList; // Enumerable.Range(1, max).Where(x => x % 5 == 0).ToList(); //Use Enumerable for one line answers.
        }

        // returns a list of all the strings in sourceList that start with the letter 'A' or 'a'
        public static List<string> MakeAList(List<string> sourceList)
        {
            List<string> results = new List<string>();

            foreach (string source in sourceList)
            {
                if (source[0] == 'A' || source[0] == 'a')
                {
                    results.Add(source);
                }
            }

            return results; // sourceList.Where(x => x.StartsWith('A') || x.StartsWith('a')).ToList();
        }
    }
}
