using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesApp
{
    public class Airplane : Vehicle
    {
        private int _altitude;
        private string _airline;
        public Airplane(int capacity) : base(capacity)
        {
        }

        public Airplane(int capacity, int speed, string airline) : base(capacity, speed)
        {
            _airline = airline;
        }

        public void Ascend(int distance) { _altitude += distance; }
        public void Descend(int distance)
        {
            var newAltitude = _altitude - distance;
            _altitude = newAltitude > 0 ? newAltitude : 0;
        }

        public override string Move()
        {
            return $"{base.Move()} at an altitude of {_altitude} metres.";
        }

        public override string Move(int times)
        {
            return $"{base.Move(times)} at an altitude of {_altitude} metres.";
        }

        public override string ToString()
        {
            return $"Thank you for flying { _airline}: {base.ToString()} altitude: {_altitude}.";
        }
    }
}
