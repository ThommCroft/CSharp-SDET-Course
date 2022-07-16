using System;
using System.Collections.Generic;
using System.Linq;

namespace SaffariParkApp
{
    public class Person : IMoveable
    {
        private string _firstName = "";
        private string _lastName = "";
        private int _age = 1;

        private readonly string _hairColour = "";

        public int Age { get { return _age; } set { _age = value < 0 ? throw new ArgumentException() : value; } }
        public string FullName => $"{_firstName} {_lastName}";

        public string HairColour { get { return _hairColour; } }

        public Person()
        {

        }

        public Person(string firstName)
        {
            _firstName = firstName;
        }

        public Person(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        public Person(string firstName, string lastName, int age, string hairColour)
        {
            _firstName = firstName;
            _lastName = lastName;
            Age = age;
            _hairColour = hairColour;
        }

        public string Move()
        {
            return "Walking along";
        }

        public string Move(int times)
        {
            return $"Walking along {times} times";
        }

        public override string ToString()
        {
            return $"{base.ToString()} Name: {FullName} Age: {Age}";
        }
    }
}
