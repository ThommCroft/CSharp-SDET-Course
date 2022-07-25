namespace FizzBuzzTests
{
    public class FizzBuzzTesting
    {
        [Test]
        public void GivenOne_Return_OneString()
        {
            Assert.That(Program.FizzBuzz(1), Is.EqualTo("1"));
        }

        [Test]
        public void GivenTwo_Return_OneTwoString()
        {
            Assert.That(Program.FizzBuzz(2), Is.EqualTo("1 2"));
        }

        [Test]
        [Ignore("No longer needed")]
        public void GivenThree_Return_OneTwoThreeString()
        {
            Assert.That(Program.FizzBuzz(3), Is.EqualTo("1 2 3"));
        }

        [Test]
        public void GivenThree_Return_OneTwoFIZZString()
        {
            Assert.That(Program.FizzBuzz(3), Is.EqualTo("1 2 Fizz"));
        }

        [Test]
        public void GivenFive_Return_OneTwoFIZZFourBUZZString()
        {
            Assert.That(Program.FizzBuzz(5), Is.EqualTo("1 2 Fizz 4 Buzz"));
        }

        [Test]
        public void GivenFifteen_Return_FizzBuzzString()
        {
            Assert.That(Program.FizzBuzz(15), Is.EqualTo("1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz"));
        }
    }
}