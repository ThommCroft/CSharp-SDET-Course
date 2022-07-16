using System;
using System.Collections.Generic;
using System.Linq;

namespace SaffariParkApp
{
    public class Vehicle : IMoveable
    {
        private int _capacity;
        private int _numPassengers;

        public int Position { get; private set; }
        public int Speed { get; init; }
        public int NumPassengers 
        { 
            get { return _numPassengers; } 
            set { _numPassengers = (value < 0 || value > _capacity) ? 
                    throw new ArgumentException("The Number of Passengers must be between 0 and the Vehicle Capacity") : value; } 
        }

        public int Capacity { get { return _capacity; } set { _capacity = value; } }

        public Vehicle()
        {
            Speed = 10;
        }

        public Vehicle(int capacity, int speed = 10)
        {
            _capacity = capacity;
            Speed = speed;
        }

        public virtual string Move()
        {
            Position += Speed;

            return "Moving along";
        }

        public virtual string Move(int times)
        {
            if (times < 0)
            {
                throw new ArgumentException();
            }

            Position = times * Speed;

            return $"Moving along {times} times";
        }

        public override string ToString()
        {
            return $"{base.ToString()} capacity: {Capacity} passengers: {NumPassengers} speed: {Speed} position: {Position}";
        }
    }
}
