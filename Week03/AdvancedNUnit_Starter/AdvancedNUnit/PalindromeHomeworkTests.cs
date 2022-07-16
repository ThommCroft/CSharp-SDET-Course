using System;
using NUnit.Framework;

namespace AdvancedNUnit
{
    public class PalindromeHomeworkTests
    {
        [TestCase("AKKA", true)]
        [TestCase("22/02/2022", true)] // Date 22/02/2022
        [TestCase("I did, did I?", true)]
        [TestCase("Sit on a potato pan, Otis", true)]
        [TestCase("Are we not drawn onward, we few, drawn onward to new era?", true)]
        public void GivenASentence_PalindromeCheck_ReturnsTrueIfSentenceIsAPalindrome(string subject, bool expectedResult)
        {
            var palindrome = new PalindromeHomework();

            Assert.That(palindrome.PalindromeCheck(subject), Is.EqualTo(expectedResult));
        }

        [Test]
        public void GivenAStringLessThan3CharactersLong_PalindromCheck_ThrowsArgumentExceptionWithMessage()
        {
            var palindrome = new PalindromeHomework();

            Assert.That(() => palindrome.PalindromeCheck("To"), Throws.TypeOf<ArgumentException>().With.Message.EqualTo("Palindromes must be 3 or more characters long."));
        }
    }
}
