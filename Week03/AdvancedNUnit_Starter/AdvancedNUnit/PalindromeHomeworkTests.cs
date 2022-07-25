using System;
using NUnit.Framework;

namespace AdvancedNUnit
{
    public class PalindromeHomeworkTests
    {
        [TestCase("AKKA")]
        [TestCase("22/02/2022")] // Date 22/02/2022
        [TestCase("I did, did I?")]
        [TestCase("Sit on a potato pan, Otis")]
        [TestCase("Are we not drawn onward, we few, drawn onward to new era?")]
        public void GivenASentence_PalindromeCheck_ReturnsTrueIfSentenceIsAPalindrome(string subject)
        {
            var palindrome = new PalindromeHomework();

            Assert.That(palindrome.PalindromeCheck(subject), Is.EqualTo(true));
        }

        [TestCase("Tom")]
        [TestCase("586")]
        [TestCase("What is this?")]
        public void GivenASentence_PalindromeCheck_ReturnsFalseIfSentenceIsAPalindrome(string subject)
        {
            var palindrome = new PalindromeHomework();

            Assert.That(palindrome.PalindromeCheck(subject), Is.EqualTo(false));
        }

        [Test]
        public void GivenAnEmptyString_PalindromCheck_ThrowsArgumentExceptionWithMessage()
        {
            var palindrome = new PalindromeHomework();

            Assert.That(() => palindrome.PalindromeCheck(""), Throws.TypeOf<ArgumentException>().With.Message.EqualTo("Palindromes must be 3 or more characters long."));
        }

        [Test]
        public void GivenAStringLessThan3CharactersLong_PalindromCheck_ThrowsArgumentExceptionWithMessage()
        {
            var palindrome = new PalindromeHomework();

            Assert.That(() => palindrome.PalindromeCheck("To"), Throws.TypeOf<ArgumentException>().With.Message.EqualTo("Palindromes must be 3 or more characters long."));
        }

        // Remember all edge cases, make sure words that are not Palindromes return false.
    }
}
