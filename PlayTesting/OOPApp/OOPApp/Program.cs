using OOPApp.Interfaces;
using OOPApp.Weapons;

using System;
using System.Collections.Generic;

namespace OOPApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Tourist> touristList = new List<Tourist>();
            List<Hunter> hunterList = new List<Hunter>();
            List<Lion> lionList = new List<Lion>();

            // Create People and Lions.
            CreateTourists(touristList);
            CreateHunters(hunterList);
            CreateLions(lionList);

            // Display their details.
            Console.WriteLine("Safari Tour\n");

            Console.WriteLine("Tourists\n");
            foreach (Tourist tour in touristList)
            {
                Console.WriteLine($"{tour.Name}, {tour.AnimalType}");
            }

            Console.WriteLine();
            Console.WriteLine("Hunters\n");

            foreach (Hunter hunt in hunterList)
            {
                Console.WriteLine($"{hunt.Name}, {hunt.AnimalType}, {hunt.Weapon.Name}");
            }

            Console.WriteLine();
            Console.WriteLine("Lions\n");

            foreach (Lion lio in lionList)
            {
                Console.WriteLine($"{lio.Name}, {lio.AnimalType}, {lio.Weapon.Name}");
            }

            Console.WriteLine();

            // Create a Safari Scenario.
        }

        // Create Weapons such as the Rifle and the Lions Paws as IAttackable
        private static void CreateTourists(List<Tourist> tourists)
        {
            var tourst01 = new Tourist("Bill");

            tourists.Add(tourst01);
        }

        private static void CreateHunters(List<Hunter> hunters)
        {
            var hunter01 = new Hunter("Alex", "Human", CreateWeapon("M-16"));

            hunters.Add(hunter01);
        }

        private static void CreateLions(List<Lion> lions)
        {
            var lion01 = new Lion("Boi", "Lion", CreateWeapon("Paws"));

            lions.Add(lion01);
        }

        private static IAttackable CreateWeapon(string name)
        {
            return new BaseWeapon(name);
        }
    }
}