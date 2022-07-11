namespace ExceptionsDataTypesTests
{
    public class GradeTests
    {
        [TestCase(-1)]
        [TestCase(-100)]
        public void WhenMarkIsLessThanZero_Grade_ThrowsAnArgumentOutOfRangeException(int mark)
        {
            //Assert.That(() => Program.Grade(mark), Throws.InstanceOf<Exception>().With.Message.Contain(", Allowed Range is 0 - 100"));
            Assert.That(() => Program.Grade(mark), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contain(", Allowed Range is 0 - 100"));
        }

        [TestCase(101)]
        [TestCase(1000)]
        public void WhenMarkIsMoreThanOneHundred_Grade_ThrowsAnArgumentOutOfRangeException(int mark)
        {
            //Assert.That(() => Program.Grade(mark), Throws.InstanceOf<Exception>().With.Message.Contain(", Allowed Range is 0 - 100"));
            Assert.That(() => Program.Grade(mark), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contain(", Allowed Range is 0 - 100"));
        }
    }
}