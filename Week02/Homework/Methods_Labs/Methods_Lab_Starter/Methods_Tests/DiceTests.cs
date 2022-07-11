using NUnit.Framework;
using System;
using Methods_Lib;

namespace Methods_Tests
{
    public class DiceTests
    {
        [TestCase(1, 3)]
        [TestCase(2, 8)]
        [TestCase(3, 7)]
        [TestCase(4, 11)]
        [TestCase(5, 5)]
        [TestCase(6, 10)]
        public void GivenARandomNumber_RollDice_ReturnsTheSumOfBothDiceAdded(int testNumber, int expectedResult)
        {
            Random rnd = new Random(testNumber);

            Assert.That(Methods.RollDice(rnd), Is.EqualTo(expectedResult));
        }
    }
}
