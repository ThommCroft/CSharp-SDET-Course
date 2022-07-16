namespace SaffariParkTest
{
    public class PersonTests
    {
        [Test]
        public void Point3DTest()
        {
            var subject = new Point3D(1, 2, 3);

            var result = subject.SumOfPoints();

            Assert.That(subject.x, Is.EqualTo(1));
            Assert.That(subject.y, Is.EqualTo(2));
            Assert.That(subject.z, Is.EqualTo(3));

            Assert.That(result, Is.EqualTo(6));
        }

        [TestCase("Cathy", "French", "Cathy French")]
        public void GetFullNameTest(string firstName, string lastName, string expectedResult)
        {
            Person person = new Person(firstName, lastName);
            var result = person.FullName;

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void AgeTest()
        {
            var person = new Person("A", "B") { Age = 33};

            Assert.That(person.Age, Is.EqualTo(33));
        }
    }
}