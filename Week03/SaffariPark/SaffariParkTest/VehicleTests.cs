namespace SaffariParkTest
{
    public class VehicleTests
    {
        [Test]
        public void TestingTheNumPassengersProperty()
        {
            var vehicle = new Vehicle(10);
            vehicle.NumPassengers = 10;

            Assert.AreEqual(10, vehicle.NumPassengers);
        }

        [Test]
        public void WhenADefaultVehicleMovesTwiceItsPositionIs20()
        {
            Vehicle vehicle = new Vehicle();

            var result = vehicle.Move(2);

            Assert.AreEqual(20, vehicle.Position);
            Assert.AreEqual("Moving along 2 times", result);
        }

        [Test]
        public void WhenADefaultVehicleMovesTenItsPositionIs1000()
        {
            Vehicle vehicle = new Vehicle();

            var result = vehicle.Move(10);

            Assert.AreEqual(100, vehicle.Position);
            Assert.AreEqual("Moving along 10 times", result);
        }

        [Test]
        public void WhenAVehicleWithSpeed40IsMovedOnceItsPositionIs40()
        {
            Vehicle vehicle = new Vehicle(5, 40);

            var result = vehicle.Move();

            Assert.AreEqual(40, vehicle.Position);
            Assert.AreEqual("Moving along", result);
        }

        [Test]
        public void WhenNumberOfPassengersIsGreaterThanOrLessThanCapacity()
        {
            //Throw an Except Test.
        }
    }
}
