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

            // Character Details.
            DisplaySafariCharacters(touristList, hunterList, lionList);

            Console.WriteLine();

            // Safari Scenario.
            SafariTourScenario(touristList, hunterList, lionList);
        }

        #region Character and Weapon Creation
        private static void CreateTourists(List<Tourist> tourists)
        {
            var tourst01 = new Tourist("Bill", CreateWeapon("Hands"));
            var tourst02 = new Tourist("Steve", CreateWeapon("Hands"));
            var tourst03 = new Tourist("Lisa", CreateWeapon("Hands"));
            var tourst04 = new Tourist("Kira", CreateWeapon("Hands"));

            tourists.Add(tourst01);
            tourists.Add(tourst02);
            tourists.Add(tourst03);
            tourists.Add(tourst04);
        }

        private static void CreateHunters(List<Hunter> hunters)
        {
            var hunter01 = new Hunter("Alex", CreateWeapon("M-16"));
            var hunter02 = new Hunter("David", CreateWeapon("M-16"));

            hunters.Add(hunter01);
            hunters.Add(hunter02);
        }

        private static void CreateLions(List<Lion> lions)
        {
            var lion01 = new Lion("Tutta", CreateWeapon("Paws"));
            var lion02 = new Lion("Xena", CreateWeapon("Paws"));
            var lion03 = new Lion("Luna", CreateWeapon("Paws"));
            var lion04 = new Lion("Fang", CreateWeapon("Paws"));
            var lion05 = new Lion("Scout", CreateWeapon("Paws"));

            lions.Add(lion01);
            lions.Add(lion02);
            lions.Add(lion03);
            lions.Add(lion04);
            lions.Add(lion05);
        }

        private static IAttackable CreateWeapon(string name)
        {
            return new BaseWeapon(name);
        }
        #endregion

        #region Character Display
        private static void DisplaySafariCharacters(List<Tourist> touristList, List<Hunter> hunterList, List<Lion> lionList)
        {
            Console.WriteLine("Safari Tour\n");

            Console.WriteLine("Tourists\n");
            foreach (Tourist tour in touristList)
            {
                Console.WriteLine($"Name: {tour.Name}, Animal Type: {tour.AnimalType}");
            }

            Console.WriteLine();
            Console.WriteLine("Hunters\n");

            foreach (Hunter hunt in hunterList)
            {
                Console.WriteLine($"Name: {hunt.Name}, Animal Type: {hunt.AnimalType}, Weapon: {hunt.Weapon.Name}");
            }

            Console.WriteLine();
            Console.WriteLine("Lions\n");

            foreach (Lion lio in lionList)
            {
                Console.WriteLine($"Name: {lio.Name}, Animal Type: {lio.AnimalType}, Weapn: {lio.Weapon.Name}");
            }
        }
        #endregion

        #region Safari Park Scenario
        private static void SafariTourScenario(List<Tourist> touristList, List<Hunter> hunterList, List<Lion> lionList)
        {
            Console.WriteLine("Safari Scenario\n");

            Console.WriteLine("A group of tourists:");

            List<string> touristNamesList = new List<string>();

            foreach (Tourist tourist in touristList)
            {
                touristNamesList.Add(tourist.Name);
            }

            Console.WriteLine(String.Join(", ", touristNamesList));
            Console.WriteLine("Are watching a group of Lions eating.\n");

            Console.WriteLine("A guide, Hunter " + hunterList[0].Name + " names all of the Lions.\n");

            List<string> lionNameList = new List<string>();

            foreach (Lion lion in lionList)
            {
                lionNameList.Add(lion.Name);
            }

            Console.WriteLine("There are: ");
            Console.WriteLine(String.Join(", ", lionNameList) + ".\n");

            Console.WriteLine($"{hunterList[1].Name} shows the tourists that {lionList[2].Name} is eating a {lionList[2].Eat("Govelle")}.\n");

            Console.WriteLine($"Suddenly from behind the tour bus, {lionList[1].Name} runs up to {touristList[3].Name} and attacks with {lionList[1].Weapon.Name}.\n");

            Console.WriteLine($"{touristList[3].Name} fights back with {touristList[3].Weapon.Name} but {hunterList[1].Attack()} {lionList[1].Name}.\n");

            Console.WriteLine($"{lionList[1].Name} falls to the ground dead.\n");

            lionList.RemoveAt(1);
            lionNameList.RemoveAt(1);

            Console.WriteLine(String.Join(", ", lionNameList) + $" run from the tour and the tourist and the hunters rush to help {touristList[3].Name}.\n");

            Console.WriteLine($"Luckily {touristList[3].Name} has minor injures, {touristList[2].Name} and {hunterList[1].Name} attend {touristList[3].Name} as the tour returns to camp.");
        }
        #endregion
    }
}