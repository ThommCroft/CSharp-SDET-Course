using System;
using System.Collections.Generic;
using System.Linq;

namespace AdvancedNUnit
{
    public class PalindromeHomework
    {
        public bool PalindromeCheck(string sentence)
        {
            // Single Letters are Palindromes but most people do not consider them as Palindromes.

            if (sentence.Length < 3)
            {
                throw new ArgumentException("Palindromes must be 3 or more characters long.");
            }

            string sentenceForward = "";

            foreach (char c in sentence.ToLower())
            {
                if (char.IsLetter(c))
                {
                    sentenceForward += c;
                }
            }

            char[] chars = sentenceForward.ToCharArray();
            Array.Reverse(chars);

            string sentenceReversed = new string(chars);

            return sentenceForward == sentenceReversed;

            //return sentence.SequenceEqual(sentence.Reverse()); // Works for single words
        }
    }
}
