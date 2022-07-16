using SaffariParkApp.Misc;

namespace SaffariParkApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create a list of hunters with weapons
            var tom = new Hunter("Tom", "Wolstencroft", RandomShooter());
            var charlie = new Hunter("Charlie", "Batten", RandomShooter());
            var nish = new Hunter("Nish", "Mandal", RandomShooter());
            var peter = new Hunter("Peter", "Bellaby", RandomShooter());

            #region Examples
            //Person jon = new Person("Jon", "Crofts", 22, "Brown");

            //Console.WriteLine(jon.FullName);
            //Console.WriteLine(jon.Age);
            //Console.WriteLine(jon.HairColour);

            //Person charlie = new Person("Charlie");

            //Console.WriteLine(charlie.FullName);
            //Console.WriteLine(charlie.Age);

            //var shop1 = new Shopping { Ties = 3, Shirt = 2, Trousers = 1 };
            //var shop2 = new Shopping { Shoes = 1 };

            //var spartan = new Spartan { FullName = "Tom", Course = "C# SDET", PersonalID = 456 };

            //Hunter maks = new Hunter("Maks", "Hadys", "Sony") { Age = 10};
            //Console.WriteLine(maks.Age);
            //Console.WriteLine(maks.Shoot());

            //var rectangle = new Rectangle(2, 3);

            //Console.WriteLine(rectangle.CalculateArea());
            #endregion

            #region Airplane
            //Airplane a = new Airplane(200, 100, "JetsRUs") { NumPassengers = 150 };

            //a.Ascend(500);
            //Console.WriteLine(a.Move(3));
            //Console.WriteLine(a);

            //a.Descend(200);
            //Console.WriteLine(a.Move());

            //a.Move();
            //Console.WriteLine(a);
            #endregion

            #region Polymorphism
            //var ellis = new Hunter("Ellis", "Witten", "Nikon") { Age = 21 };
            //var plane = new Airplane(400, 200, "Virgin");
            //var vehicle = new Vehicle(20, 20);
            //var kenny = new Person("Kenny", "Harvey") { Age = 22};

            //List<Object> gameObs = new List<object>()
            //{
            //    ellis, plane, vehicle, kenny
            //};

            //foreach (var gameObj in gameObs)
            //{
            //    Console.WriteLine(gameObj);
            //}

            //SpartaWrite(ellis);

            //var ellis2 = (Person)ellis;
            //Console.WriteLine(ellis2.Equals(ellis));
            #endregion

            #region Polymorphism Exercise
            //var person = new Person("Derick", "Dude") { Age = 50};
            //var vehicle2 = new Vehicle(10, 5);

            //List<IMoveable> newObjectList = new List<IMoveable>() { person, vehicle2 };

            //foreach (var obj in newObjectList)
            //{
            //    Console.WriteLine(obj);
            //    Console.WriteLine(obj.Move());
            //}
            #endregion

            #region Lists
            List<int> numbersList = new List<int>() { 5, 4, 3, 9, 0 };

            numbersList.Add(8);
            numbersList.Sort();
            numbersList.RemoveRange(1, 2);
            numbersList.Insert(2, 1);
            numbersList.Reverse();
            numbersList.Remove(9);

            numbersList.ForEach(x => Console.Write(x));

            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region Queues
            var peopleQueue = new Queue<Person>();
            peopleQueue.Enqueue(tom);
            peopleQueue.Enqueue(charlie);
            peopleQueue.Enqueue(nish);
            peopleQueue.Enqueue(peter);

            Console.WriteLine("Queue\n");

            foreach (var person in peopleQueue)
            {
                Console.WriteLine(person);
            }

            Console.WriteLine();

            var first = peopleQueue.Peek();
            Console.WriteLine(first);

            Console.WriteLine();

            var serve = peopleQueue.Dequeue();
            Console.WriteLine(serve);

            Console.WriteLine();

            foreach (var person in peopleQueue)
            {
                Console.WriteLine(person);
            }

            Console.WriteLine();
            #endregion

            #region Stacks
            Console.WriteLine("Stack\n");

            var myStack = new Stack<Person>();

            myStack.Push(tom);
            myStack.Push(charlie);
            myStack.Push(nish);
            myStack.Push(peter);

            foreach (var person in myStack)
            {
                Console.WriteLine(person);
            }

            Console.WriteLine();

            var last = myStack.Peek();
            Console.WriteLine(last);

            Console.WriteLine();

            var personPop = myStack.Pop();
            Console.WriteLine(personPop);

            Console.WriteLine();

            foreach (var person in myStack)
            {
                Console.WriteLine(person);
            }

            Console.WriteLine();
            #endregion

            #region HashSet
            Console.WriteLine("HashSet\n");

            var paul = new Person("Paul", "Man") { Age = 21 };
            var derick = new Person("Derick", "Man") { Age = 21 };
            var dave = new Person("Dave", "Dude") { Age = 21 };

            var peopleSet = new HashSet<Person>()
            {
                paul, derick, dave
            };

            foreach (var entry in peopleSet)
            {
                Console.WriteLine(entry);
            }

            Console.WriteLine();

            var successPaul = peopleSet.Add(new Person("Paul", "Man") { Age = 21 });
            var successMartin = peopleSet.Add(new Person("Martin", "Beard") { Age = 21 });
            var successTom = peopleSet.Add(new Person("Tom", "Wolstencroft"));

            foreach (var entry in peopleSet)
            {
                Console.WriteLine(entry);
            }

            Console.WriteLine();

            var morePeople = new HashSet<Person> { new Person("Cathy"), new Person("Ken"), new Person("Tom") };

            peopleSet.IntersectWith(morePeople);

            foreach (var entry in peopleSet)
            {
                Console.WriteLine(entry);
            }

            Console.WriteLine();
            #endregion

            #region Dictionaries
            Console.WriteLine("Dictionary\n");

            Dictionary<string, Person> persons = new Dictionary<string, Person>()
            {
                {"Tom", tom},
                {"Charlie", charlie},
                {"Nish", nish},
                {"Peter", peter}
            };

            var personInDict = persons["Tom"];
            Console.WriteLine(personInDict);

            persons.Add("Bill", new Person("Bill", "Will"));

            string input = "The cat in the hat comes back";
            input = input.Trim().ToLower();

            var countDict = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (countDict.ContainsKey(c))
                {
                    countDict[c]++;
                }
                else
                {
                    countDict.Add(c, 1);
                }
            }

            foreach (var entry in countDict)
            {
                Console.WriteLine($"[{entry.Key}, {entry.Value}]");
            }

            Console.WriteLine();

            foreach (var key in countDict.Keys)
            {
                Console.Write($" Key: {key}");
            }

            Console.WriteLine();
            #endregion

            var hunters = new List<Hunter>();

            hunters.Add(tom);
            hunters.Add(charlie);
            hunters.Add(nish);
            hunters.Add(peter);

            #region Display Hunters
            foreach (Hunter hunter in hunters)
            {
                Console.WriteLine(hunter.Shoot());
            }
            #endregion

            #region Shooter Game
            // loop through the hunters and have them die randomly from other hunters killing them

            //while (hunters.Count > 1)
            //{
            //    for (int i = 0; i < hunters.Count; i++)
            //    {
            //        // Hunters Randomly Shoot each other, the victim is removed from the list.
            //        string result = $"{hunters[i].Shoot()} to shoot {RandomHunter(hunters, hunters[i])}";

            //        Console.WriteLine(result);
            //    }
            //}

            //// the game ends when 1 hunter is left.
            //if (hunters.Count == 1)
            //{
            //    Console.WriteLine($"{hunters[0].FullName} won the match!");
            //}
            #endregion
        }

        private static string RandomHunter(List<Hunter> huntersList, Hunter currentHunter)
        {
            // Get a Random Hunter and Exclude the Current Hunter.
            Random random = new Random();
            int randomHunter = random.Next(0, huntersList.Count);

            // Check if the Hunter Died from a Weapon, if they did, then remove them from the list.

            if (currentHunter.Shooter.Equals(typeof(Weapon))) // Check the Weapon is a RPG or LaserGun Bug(Isn't True)
            {
                huntersList.RemoveAt(randomHunter);

                // shuffle the list with the remaining Hunters.

                return $"{huntersList[randomHunter].FullName} (Weapon Used)";
            }
            else
            {
                return $"{huntersList[randomHunter].FullName}";
            }
        }

        private static IShootable RandomShooter()
        {
            Random rd = new Random();
            int number = rd.Next(100);

            if (number < 40)
            {
                return new RPG("RPG-22");
            }
            else if (number > 40 && number < 75)
            {
                return new LaserGun("Mosguito");
            }
            else
            {
                return new Camera("Canon");
            }
        }

        public static void SpartaWrite(Object obj)
        {
            Console.WriteLine(obj);

            if (obj is Hunter)
            {
                var hunterObj = (Hunter)obj;

                Console.WriteLine(hunterObj.Shoot());
            }
        }
    }
}