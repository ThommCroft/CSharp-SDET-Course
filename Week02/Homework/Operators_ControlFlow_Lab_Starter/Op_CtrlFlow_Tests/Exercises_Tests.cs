using NUnit.Framework;
using Op_CtrlFlow;
using System.Collections.Generic;

namespace Op_CtrlFlow_Tests
{
    public class Exercises_Tests
    {
        // write unit test(s) for MyMethod here
        [TestCase(2, 2, false)]
        [TestCase(16, 4, true)]
        [TestCase(5, 2, false)]
        public void GivenASetofNumbers_MyMethod_ReturnsEitherTrueOrFalseIfTheyAreEqualOrGiveARemainder(int num1, int num2, bool result)
        {
            Assert.That(Exercises.MyMethod(num1, num2), Is.EqualTo(result));
        }

        [Test]
        public void Average_ReturnsCorrectAverage()
        {
            var myList = new List<int>() { 3, 8, 1, 7, 3 };
            Assert.That(Exercises.Average(myList), Is.EqualTo(4.4));
        }

        [Test]
        public void WhenListIsEmpty_Average_ReturnsZero()
        {
            var myList = new List<int>() {};
            Assert.That(Exercises.Average(myList), Is.EqualTo(0));
        }

        [TestCase(100, "OAP")]
        [TestCase(60, "OAP")]
        [TestCase(59, "Standard")]
        [TestCase(18, "Standard")]
        [TestCase(17, "Student")]
        [TestCase(13, "Student")]
        [TestCase(12, "Child")]
        [TestCase(5, "Child")]
        [TestCase(4, "Free")]
        [TestCase(0, "Free")]
        public void TicketTypeTest(int age, string expected)
        {
            var result = Exercises.TicketType(age);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(0, "Fail")]
        [TestCase(39, "Fail")]
        [TestCase(40, "Pass")]
        [TestCase(59, "Pass")]
        [TestCase(60, "Pass with Merit")]
        [TestCase(74, "Pass with Merit")]
        [TestCase(75, "Pass with Distinction")]
        [TestCase(100, "Pass with Distinction")]
        public void GivenAGradeMark_Grade_ReturnTheCorrectGradeString(int mark, string expected)
        {
            Assert.That(Exercises.Grade(mark), Is.EqualTo(expected));
        }

        [TestCase(4, 20)]
        [TestCase(3, 50)]
        [TestCase(2, 50)]
        [TestCase(1, 100)]
        [TestCase(0, 200)]
        public void GivenACovidLevel_GetScottishMaxWeddingNumbers_ReturnTheMaxNumberOfWeddingAttendees(int covidLevel, int expectedMaxAttendees)
        {
            Assert.That(Exercises.GetScottishMaxWeddingNumbers(covidLevel), Is.EqualTo(expectedMaxAttendees));
        }
    }
}
