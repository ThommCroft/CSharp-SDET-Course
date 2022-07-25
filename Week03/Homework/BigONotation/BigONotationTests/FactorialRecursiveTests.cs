namespace BigONotationTests
{
    public class Tests
    {
        [TestCase(-1)]
        [TestCase(0)]
        public void GivenNLess1_FactorialRecusive_ThrowException(int subject)
        {
            Assert.That(() => Program.FactorialRecursive(subject), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contain("n has to between 1 and 21"));
        }

        [Test]
        public void GivenNGreater21_FactorialRecusive_ThrowException()
        {
            Assert.That(() => Program.FactorialRecursive(22), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contain("n has to between 1 and 21"));
        }
    }
}