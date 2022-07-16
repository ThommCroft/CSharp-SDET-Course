namespace ComparingObjectsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nish = new Person("Nish", "Mandal") { Age = 22};
            //var david = nish;

            //var tom = new Person("Tom", "Wolstencroft") { Age = 22 };

            //Console.WriteLine(nish.Equals(david));
            //Console.WriteLine(nish.Equals(tom));

            var bob = new Person("Bob", "Builder") { Age = 25 };

            var people = new List<Person>()
            {
                new Person("Cath", "Cookson"),
                new Person("Bob", "Builder") { Age = 25 },
                new Person("Dan", "Dare"),
                new Person("Amy", "Andrews") { Age = 32 },
            };

            var hasBob = people.Where(x => x.GetFullName() == "Bob Builder").Any(); // true

            bool hasBob2 = people.Contains(bob); // false

            people.ForEach(x => Console.WriteLine(x.GetFullName()));
            people.Sort();
            Console.WriteLine();
            people.ForEach(x => Console.WriteLine(x.GetFullName()));

            // Less than Zero, nish comes before bob
            // More than Zero, nish comes after bob
            // Zero, nish and bob are in the same position
            nish.CompareTo(bob);
        }
    }

    public class Person : IEquatable<Person?>, IComparable<Person?>
    {
        private string _firstName;
        private string _lastName;
        private int _age;

        public Person() { }

        public Person(string fName, string lName)
        {
            _firstName = fName;
            _lastName = lName;
        }

        public int Age
        {
            get { return _age; }
            set { if (value >= 0) _age = value; }
        }

        public int CompareTo(Person? other)
        {
            if (other == null)
            {
                return 1;
            }

            if (this._lastName != other._lastName)
            {
                return this._lastName.CompareTo(other._lastName);
            }
            else if (this._firstName != other._firstName)
            {
                return this._firstName.CompareTo(other._firstName);
            }
            else
            {
                return this._age.CompareTo(other._age);
            }
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Person);
        }

        public bool Equals(Person? other)
        {
            return other is not null &&
                   _firstName == other._firstName &&
                   _lastName == other._lastName &&
                   _age == other._age;
        }

        public string GetFullName()
        {
            return $"{_firstName} {_lastName}";
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_firstName, _lastName, _age);
        }

        public static bool operator ==(Person? left, Person? right)
        {
            return EqualityComparer<Person>.Default.Equals(left, right);
        }

        public static bool operator !=(Person? left, Person? right)
        {
            return !(left == right);
        }
    }
}