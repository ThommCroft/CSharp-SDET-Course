using System;
using System.Collections.Generic;
using System.Linq;

namespace SaffariParkTest
{
    public class AirplaneTests
    {
        private Airplane a;

        [SetUp]
        public void SetUp()
        {
            a = new Airplane(200, 100, "JetsRUs") { NumPassengers = 150 };
        }

        [Test]
        public void TestingTheAscendMethod()
        {
            a.Ascend(500);

            Assert.That(a.Altitude, Is.EqualTo(500));
        }

        [Test]
        public void TestingTheDescendMethod()
        {
            a.Ascend(600);
            a.Descend(300);

            Assert.That(a.Altitude, Is.EqualTo(300));
        }

        [Test]
        public void TestingTheMoveMethod()
        {
            a.Ascend(300);
            var result = a.Move();

            Assert.That(result, Is.EqualTo("Moving along at an altitude of 300 metres."));
        }

        [Test]
        public void TestingTheMoveMethodWithParameter()
        {
            a.Ascend(500);
            var result = a.Move(3);

            Assert.That(result, Is.EqualTo("Moving along 3 times at an altitude of 500 metres."));
        }

        [TestCase(12600)]
        [TestCase(14000)]
        [TestCase(20000)]
        public void WhenTheAirplaneAltitudeIsAbove12500metersThrowsArgumentException(int altitude)
        {
            a.Ascend(altitude);

            Assert.That(() => a.Ascend(altitude), 
                Throws.TypeOf<ArgumentException>().With.Message.EqualTo("Planes should not fly above their design capabilities!"));
        }

        [TestCase(300)]
        [TestCase(400)]
        public void WhenTheAirplaneAltitudeIsBelow300metersThrowsArgumentException(int altitude)
        {
            a.Ascend(500);
            a.Descend(altitude);

            Assert.That(() => a.Descend(altitude), Throws.TypeOf<ArgumentException>().With.Message.EqualTo("Planes cannot fly below 300 meters!"));
        }
    }
}
