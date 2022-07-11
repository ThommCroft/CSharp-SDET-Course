using OperatorsApp;

namespace OperatorsControlFlowTests
{
    public class StoneTests
    {
        [TestCase(152, 10)]
        public void Given152Pounds_GetStones_Returns10Stone(int totalPounds, int expectedResult)
        {
            Assert.That(Methods.GetStones(totalPounds), Is.EqualTo(expectedResult));
        }

        [TestCase(156, 2)]
        public void Given156Pounds_GetPounds_Returns2Pounds(int totalPounds, int expectedResult)
        {
            Assert.That(Methods.GetPounds(totalPounds), Is.EqualTo(expectedResult));
        }

        [TestCase(14, 1)]
        [TestCase(13, 0)]
        [TestCase(15, 1)]
        public void GivenANumberOfPounds_GetStones_ReturnsNumberInStone(int totalPounds, int expectedResult)
        {
            Assert.That(Methods.GetStones(totalPounds), Is.EqualTo(expectedResult));
        }

        [TestCase(14, 0)]
        [TestCase(15, 1)]
        public void GivenANumberOfPounds_GetPounds_ReturnsRemainderOfPounds(int totalPounds, int expectedResult)
        {
            Assert.That(Methods.GetPounds(totalPounds), Is.EqualTo(expectedResult));
        }
    }
}