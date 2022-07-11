using ControlFlowApp;

namespace OperatorsControlFlowTests
{
    public class SelectionTests
    {
        [TestCase(10)]
        public void GivenAMarkOf10_Grade_ReturnsFail(int mark)
        {
            Assert.That(Program.Grade(mark), Is.EqualTo("Fail"));
        }
        [TestCase(70)]
        public void GivenAMarkOf70_Grade_ReturnsPass(int mark)
        {
            Assert.That(Program.Grade(mark), Is.EqualTo("Pass"));
        }

        [TestCase(90)]
        public void GivenAMarkOf90_Grade_ReturnsDestinction(int mark)
        {
            Assert.That(Program.Grade(mark), Is.EqualTo("Distinction"));
        }

        [TestCase(64, "Fail")]
        [TestCase(65, "Pass")]
        [TestCase(66, "Pass")]

        [TestCase(84, "Pass")]
        [TestCase(85, "Distinction")]
        [TestCase(86, "Distinction")]
        public void GivenABoundaryMark_Grade_ReturnsGrade(int mark, string expectedResult)
        {
            Assert.That(Program.Grade(mark), Is.EqualTo(expectedResult));
        }
    }
}
