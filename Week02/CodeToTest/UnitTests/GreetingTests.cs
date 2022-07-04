using CodeToTest;

namespace UnitTests
{
    public class GreetingTests
    {
        [Test]
        public void GivenATimeof21_Greeting_ReturnsGoodEvening()
        {
            var time = 21;
            var expectedGreeting = "Good Evening!";
            var result = Program.Greeting(time);

            Assert.That(result, Is.EqualTo(expectedGreeting));
        }
    }
}