using System;
using System.Threading;
using System.Threading.Tasks;

namespace AysncCake
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            Console.WriteLine("Welcome to my birthday party");
            await HaveAPartyAsync();
            Console.WriteLine("Thanks for a lovely party");
            Console.ReadLine();
        }

        // Void --> Task
        private static async Task HaveAPartyAsync()
        {
            var name = "Cathy";
            var cakeTask = BakeCakeAsync();
            var drinksTask = MakeDrinksAsync();

            PlayPartyGames();
            OpenPresents();

            var cake = await cakeTask;
            var drink = await drinksTask;

            Console.WriteLine($"{drink}");
            Console.WriteLine($"Happy birthday, {name}, {cake}!!");
        }

        // Cake --> Task<Cake>
        private static async Task<Cake> BakeCakeAsync() // When using Async, work your way backwards with the task to make sure every works correctly in the call tree.
        {
            Console.WriteLine("Cake is in the oven");

            // Wait for this task to be complete, whilst waiting, go back to the caller method.
            await Task.Delay(TimeSpan.FromSeconds(5));

            Console.WriteLine("Cake is done");
            return new Cake();
        }

        private static async Task<Drink> MakeDrinksAsync() // Add some more async methods to the AsyncCake app - what else can we do at a party?
        {
            Console.WriteLine("Glasses are on a tray");

            await Task.Delay(TimeSpan.FromSeconds(3));

            Console.WriteLine("Drinks have been poured out");
            return new Drink();
        }

        private static void PlayPartyGames() // Play a game whilst waiting for the cake.
        {
            Console.WriteLine("Starting games");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Console.WriteLine("Finishing Games");
        }

        private static void OpenPresents() // Display different presents.
        {
            Console.WriteLine("Opening Presents");
            Thread.Sleep(TimeSpan.FromSeconds(1));
            Console.WriteLine("Finished Opening Presents");
        }
    }

    public class Cake
    {
        public override string ToString()
        {
            return "Here's a cake";
        }
    }

    public class Drink
    {
        public override string ToString()
        {
            return "Cathy is drunk!";
        }
    }
}
