using CodeToTest;

namespace UnitTests
{
    public class GreetingTests
    {
        [Test]
        public void GivenATimeof10_Greeting_ReturnsGoodMorning()
        {
            // Arrange Test
            var time = 10;
            var expectedGreeting = "Good Morning!";

            Assert.That(Program.Greeting(time), Is.EqualTo(expectedGreeting));
        }

        [Test]
        public void GivenATimeof14_Greeting_ReturnsGoodAfternoon()
        {
            // Arrange Test
            var time = 14;
            var expectedGreeting = "Good Afternoon!";

            Assert.That(Program.Greeting(time), Is.EqualTo(expectedGreeting));
        }

        [Test]
        public void GivenATimeof21_Greeting_ReturnsGoodEvening()
        {
            // Arrange Test
            var time = 21;
            var expectedGreeting = "Good Evening!";

            Assert.That(Program.Greeting(time), Is.EqualTo(expectedGreeting));
        }

        [Test]
        public void GivenATimeof3_Greeting_ReturnsGoodEvening()
        {
            // Arrange Test
            var time = 3;
            var expectedGreeting = "Good Evening!";

            Assert.That(Program.Greeting(time), Is.EqualTo(expectedGreeting));
        }

        [TestCase(5)]
        [TestCase(8)]
        [TestCase(12)]
        public void GivenATimeBetween5And12_Greeting_ReturnsGoodMorning(int time)
        {
            var expectedGreeting = "Good Morning!";

            Assert.That(Program.Greeting(time), Is.EqualTo(expectedGreeting));
        }

        [TestCase(18, "Good Afternoon!")]
        [TestCase(19, "Good Evening!")]
        [TestCase(4, "Good Evening!")]
        [TestCase(-1, "Good Evening!")]
        [TestCase(25, "Good Evening!")]
        public void GivenABoundaryTime_Greeting_ReturnsExpectedGreeting(int time, string expectedGreeting)
        {
            Assert.That(Program.Greeting(time), Is.EqualTo(expectedGreeting));
        }

        //[TestCase(-1)]
        //[TestCase(25)]
        //public void GivenAnInvalidTime_Greeting_ReturnsAnError(int time)
        //{
        //    Assert.That(() => Program.Greeting(time), Throws.TypeOf<ArgumentOutOfRangeException>());
        //}
    }
}