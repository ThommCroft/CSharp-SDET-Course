using NUnit.Framework;
using Methods_Lib;
using System;

namespace Methods_Tests
{
    public class TuplesTests
    {
        [TestCase(25, 3, 4)]
        [TestCase(0, 0, 0)]
        [TestCase(33, 4, 5)]
        public void GivenANumber_DaysAndWeeks_ReturnsCorrectTuple(
            int totalDays, int expectedWeeks, int expectedDays)
        {
            var answer = Methods.DaysAndWeeks(totalDays);
            Assert.That(answer.weeks, Is.EqualTo(expectedWeeks), "Weeks");
            Assert.That(answer.days, Is.EqualTo(expectedDays), "Days");
        }

        [Test]
        public void GivenANegativeNumber_DaysAndWeeks_ThrowsAnException()
        {
            Assert.That(() => Methods.DaysAndWeeks(-1), Throws.TypeOf<ArgumentOutOfRangeException>()
        .With.Message.Contain("totalDays must not be negative"));
        }

        [TestCase(25, 625, 15625, 1)]
        [TestCase(9, 81, 729, 1)]
        [TestCase(658, 432964, 284890312, 1)]
        public void GivenANumber_PowersRoot_ReturnsCorrectTuple(int testNumber, int expectedSquare, int expectedCube, double expectedSquareRoot)
        {
            var answer = Methods.PowersRoot(testNumber);

            Assert.That(answer.squared, Is.EqualTo(expectedSquare), "Square");
            Assert.That(answer.cubed, Is.EqualTo(expectedCube), "Cube");
            Assert.That(answer.squareRoot, Is.EqualTo(expectedSquareRoot), "SquareRoot");
        }
    }
}