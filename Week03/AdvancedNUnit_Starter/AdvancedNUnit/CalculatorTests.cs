using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace AdvancedNUnit
{
    [TestFixture] // Marks a Class as a Test Class.
    public class CalculatorTests
    {
        // Command prompt Test Commands:
        //  dotnet test --list-tests
        //  dotnet test

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            // Tests one object in many methods.
        }

        [SetUp]
        public void Setup()
        {

        }
        //Tests maybe run in parallel, they do not have a specific order.

        private static object[] AddCases = { new int[] { 2, 4, 6 }, new int[] { -2, 4, 2 } }; // Useful for testing objects that need instaniating.

        [TestCaseSource("AddCases")] //[TestCase(2, 4, 6)]
        [Category("Happy Path")]
        public void Add_Always_ReturnsExpectedResult(int x, int y, int expectedResult)
        {
            // Arrange
            var subject = new Calculator { Num1 = x, Num2 = y };

            // Act
            var result = subject.Add();

            // Assert
            Assert.That(result, Is.EqualTo(expectedResult), "optional failure message");
        }

        #region Examples
        [Test]
        public void SomeConstraints()
        {
            var subject = new Calculator() { Num1 = 6 };

            Assert.That(subject.DivisibleBy3());

            subject.Num1 = 7;

            Assert.That(subject.DivisibleBy3(), Is.False);

            Assert.That(subject.ToString(), Does.Contain("Calculator"));
        }

        [Test]
        public void StringConstraints()
        {
            var subject = new Calculator() { Num1 = 2, Num2 = 4 };
            var strResult = subject.ToString();

            Assert.That(strResult, Is.EqualTo("AdvancedNUnit.Calculator"));

            Assert.That(strResult, Does.Contain("Calculator"));

            Assert.That(strResult, Does.Not.Contain("Potato"));

            Assert.That(strResult, Is.EqualTo("AdvancedNUnit.Calculator").IgnoreCase);

            Assert.That(strResult, Is.Not.Empty);
        }

        [Test]
        public void TestArrayOfStrings()
        {
            var fruit = new List<string>() { "apple", "pear", "banana", "peach" };

            Assert.That(fruit, Does.Contain("pear"));
            Assert.That(fruit, Does.Not.Contain("kiwi"));

            Assert.That(fruit, Has.Count.EqualTo(4));
            Assert.That(fruit, Has.Exactly(2).StartsWith("pea"));
        }

        [Test]
        public void TestRange()
        {
            Assert.That(8, Is.InRange(1, 10));

            List<int> nums = new List<int>() { 4, 2, 7, 5, 9 };

            //Assert.That(nums.Count, Is.All.InRange(1, 10));

            Assert.That(nums, Has.Exactly(2).InRange(1, 4));
        }

        [Test]
        public void PlayTest()
        {
            var stringList = new List<string>() { "Bob", "Dave", "Gertrude", "Steve", "James" };

            Assert.That(stringList, Does.Contain("Steve").And.Contain("James"));
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            // Called Once after all Child Tests have run.
            // Will always run even when an Exception is called.
        }

        [TearDown]
        public void TearDown()
        {
            // Called immediately after all Child Tests have run.
            // Will always run even when an Exception is called.
        }
        #endregion

        [Test]
        [Category("Error Path")]
        public void GivenANumberDivide_Divide_ThrowDivideByZero()
        {
            var subject = new Calculator { Num1 = 2, Num2 = 0 };

            Assert.That(() => subject.Divide(), Throws.TypeOf<ArgumentException>().With.Message.EqualTo("Can't divide by zero"));
        }
    }
}