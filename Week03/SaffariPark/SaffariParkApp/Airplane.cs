using System;
using System.Collections.Generic;
using System.Linq;

namespace SaffariParkApp
{
    public class Airplane : Vehicle
    {
        private string _airline = "";

        public int Altitude { get; private set; }

        public Airplane(int capacity) : base(capacity)
        {

        }

        public Airplane(int capacity, int speed, string airline) : base(capacity, speed)
        {
            _airline = airline;
        }

        public void Ascend(int distance)
        {
            if (Altitude > 12500)
            {
                throw new ArgumentException("Planes should not fly above their design capabilities!");
            }

            Altitude += distance;
        }

        public void Descend (int distance)
        {
            if (Altitude < 300)
            {
                throw new ArgumentException("Planes cannot fly below 300 meters!");
            }
            
            Altitude -= distance;
        }

        public override string Move()
        {
            return $"{base.Move()} at an altitude of {Altitude} metres.";
        }

        public override string Move(int times)
        {
            return $"{base.Move(times)} at an altitude of {Altitude} metres.";
        }

        public override string ToString()
        {
            return $"Thank you for flying {_airline}: {base.ToString()} altitude: {Altitude}";
        }
    }
}
