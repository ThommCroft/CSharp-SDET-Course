namespace StringCalculatorTesting
{
    public class Tests
    {
        [Test]
        public void GivenAnEmptyString_Add_ReturnZero()
        {
            Assert.That(Program.Add(""), Is.EqualTo(0));
        }

        [Test]
        public void GivenAStringWithTwoNumbersSeperatedByAComma_Add_ReturnSum()
        {
            Assert.That(Program.Add("1,2"), Is.EqualTo(3));
        }
    }
}