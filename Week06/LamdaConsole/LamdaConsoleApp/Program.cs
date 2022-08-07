namespace LambdaConsoleApp
{
    public class Program
    {
        /*
         * Lambdas:
         * Have no name
         * Is declared at the place it is used
         * Cannot be reused anywhere else
         * The types of parameters are inferred from context
         * 
         * Parameters Methods Accepted:
         * .Sum(method that returns a number)
         * .Where(method that returns a bool)
         * .OrderBy(method which returns a key)
         * .Sum(method that returns a bool)
         */

        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 3, 7, 1, 2, 8, 3, 0, 4, 5};

            // IEnumerable allows a list to be iterated through.
            int nunbersCount = numbers.Count();

            // You can pass a method into count but it must return a bool value
            int nunbersCount2 = numbers.Count(IsEven);

            // Using a Delegate (Anonymous method), Do not use Anonymous Methods.
            int nunbersCount3 = numbers.Count(delegate (int n) { return n % 2 == 0; });

            // Lambda Expression
            int nunbersCount4 = numbers.Count(x => x % 2 == 0);

            var people = new List<Person>
            {
                new Person{Name = "Nish", Age = 40, City = "Birmingham"},
                new Person{Name = "Cathy", Age = 20, City = "Ottawa"},
                new Person{Name = "Peter", Age = 55, City = "London"}
            };

            // Using a Method
            int countYoungPeople = people.Count(IsYoung);
            Console.WriteLine(countYoungPeople);

            // Using a Lambda
            int countYoungPeople2 = people.Count(x => x.Age < 30);
            Console.WriteLine(countYoungPeople2);

            int totalAge = people.Sum(x => x.Age);
            Console.WriteLine(totalAge);

            // Exercise
            // Using Lambda, in one line find the total age of people older than or equal to 30

            //int equalOlderPeople = people.Select(x => x.Age >= 30).Sum(Age); // x => (x.Age >= 30) : 0;

            // QUERY STATEMENTS:

            // WHERE query
            var londonPeopleQuery = people.Where(p => p.City == "London");

            foreach (var p in londonPeopleQuery)
            {
                Console.WriteLine(p);
            }

            // ORDER BY query
            var peopleOrderByAge = people.OrderBy(x => x.Age).OrderByDescending(x => x.Name);

            foreach (var p in peopleOrderByAge)
            {
                Console.WriteLine(p);
            }

            // SELECT query
            var londonAgeQuery = people.Where(p => p.City == "London").Select(x => x.Age);

            foreach (var p in londonAgeQuery)
            {
                Console.WriteLine(p);
            }



            // Anonymous Type Query (Out of Scope for the Course)
            var employee = new { Age = 30, Name = 12 };
            var londonQueryAnon = people.Select(x => new { FullName = x.Name });

            foreach (var p in londonQueryAnon)
            {
                Console.WriteLine(p);
            }
        }

        public static bool IsEven(int num)
        {
            return num % 2 == 0;
        }

        public static bool IsYoung(Person person)
        {
            return person.Age < 30;
        }
    }
}