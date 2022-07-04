using CodeToTest;

namespace UnitTests
{
    public class AvailableClassificationTests
    {
        [TestCase(11, "U & PG Films are available.")]
        public void GivenAnAgeUnder12_AvailableClassification_ReturnsExpectedClassification(int age, string expectedClassification)
        {
            Assert.That(Program.AvailableClassification(age), Is.EqualTo(expectedClassification));
        }

        [TestCase(14, "U, PG, 12A & 12 Films are available.")]
        public void GivenAnAgeUnder15_AvailableClassification_ReturnsExpectedClassification(int age, string expectedClassification)
        {
            Assert.That(Program.AvailableClassification(age), Is.EqualTo(expectedClassification));
        }

        [TestCase(17, "U, PG, 12 & 15 Films are available.")]
        public void GivenAnAgeUnder18_AvailableClassification_ReturnsExpectedClassification(int age, string expectedClassification)
        {
            Assert.That(Program.AvailableClassification(age), Is.EqualTo(expectedClassification));
        }

        [TestCase(18, "All Films are available.")]
        public void GivenAnAgeOver18_AvailableClassification_ReturnsExpectedClassification(int age, string expectedClassification)
        {
            Assert.That(Program.AvailableClassification(age), Is.EqualTo(expectedClassification));
        }

        [TestCase(0, "U & PG Films are available.")]
        [TestCase(1, "U & PG Films are available.")]
        [TestCase(11, "U & PG Films are available.")]
        [TestCase(12, "U, PG, 12A & 12 Films are available.")]
        [TestCase(13, "U, PG, 12A & 12 Films are available.")]
        [TestCase(14, "U, PG, 12A & 12 Films are available.")]
        [TestCase(16, "U, PG, 12 & 15 Films are available.")]
        [TestCase(18, "All Films are available.")]
        [TestCase(30, "All Films are available.")]
        [TestCase(105, "All Films are available.")]
        public void GivenANewAge_AvailableClassification_ReturnsExpectedClassification(int age, string expectedClassification)
        {
            Assert.That(Program.AvailableClassification(age), Is.EqualTo(expectedClassification));
        }
    }
}