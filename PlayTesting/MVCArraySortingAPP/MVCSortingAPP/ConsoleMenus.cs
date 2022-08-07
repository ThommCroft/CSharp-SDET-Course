using MVCSortingAppController;

namespace MVCSortingAppView
{
    public class ConsoleMenus
    {
        private Controller controller = new Controller();

        private void SortingAppHeader()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Array Sorting App");
            Console.WriteLine("-----------------");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;
        }

        public void MainMenu()
        {
            SortingAppHeader();

            Console.WriteLine("Welcome to Array Sorter, would you like to start?");
            Console.WriteLine("Yes[Y], Help[H] Exit[E]");
            string userInput = Console.ReadLine().ToLower();

            Console.WriteLine();

            if (userInput == "y")
            {
                ArrayCreationMenu();
            }
            else if (userInput == "h")
            {
                UserInputHelpMenu();
            }
            else if (userInput == "e")
            {
                Environment.Exit(0);
            }
        }

        private void ArrayCreationMenu()
        {
            SortingAppHeader();

            Console.WriteLine("Would you like to create an Array or generate a Random Array?");
            Console.WriteLine("Create[C], Random[R]");
            Console.WriteLine();

            string userInput = Console.ReadLine().ToLower().Replace(" ", "");

            if (userInput == "c")
            {
                CreateArrayMenu();
            }
            else if (userInput == "r")
            {
                int[] randomNumbersArray = controller.GenerateRandomArray();
                SortAlgorithmMenu(randomNumbersArray);
            }
        }

        private void CreateArrayMenu()
        {
            SortingAppHeader();

            Console.WriteLine("Please specify the Array length (Whole Numbers Only)");
            string userArrayLength = Console.ReadLine().Replace(" ", "");
            int arraylength = Int32.Parse(userArrayLength);

            Console.WriteLine();
            Console.WriteLine("Please specify the Array length (Whole Numbers Only)");
            string userMinimumRange = Console.ReadLine().Replace(" ", "");
            int arrayMinimumRange = Int32.Parse(userMinimumRange);

            Console.WriteLine();
            Console.WriteLine("Please specify the Array length (Whole Numbers Only)");
            string userMaximumRange = Console.ReadLine().Replace(" ", "");
            int arrayMaximumRange = Int32.Parse(userMaximumRange);

            int[] createdNumbersArray = controller.CreatedNumbersArray(arrayMinimumRange, arrayMaximumRange, arraylength);
            SortAlgorithmMenu(createdNumbersArray);
        }

        private void SortAlgorithmMenu(int[] numbersArray)
        {
            SortingAppHeader();

            Console.WriteLine("Here is an Unordered Array:");
            Console.WriteLine();

            string arrayString = DisplayRandomArray(numbersArray);

            Console.WriteLine("Array: " + arrayString);
            Console.WriteLine();

            Console.WriteLine("Which Sort Algorithm would you like to use? Or return to Main Menu");
            Console.WriteLine();

            Console.WriteLine("0 Main Menu");
            Console.WriteLine("1 Bubble Sort");
            Console.WriteLine("2 Merge Sort");
            Console.WriteLine("3 .NET Sort");
            Console.WriteLine();

            var sortCheck = Console.ReadLine().ToLower().Replace(" ", "");
            Console.WriteLine();

            if (sortCheck == "menu" || sortCheck == "main" || sortCheck == "mainmenu" || sortCheck == "0")
            {
                Console.Clear();
                MainMenu();
            }
            else if (sortCheck == "bubble" || sortCheck == "bubblesort" || sortCheck == "1")
            {
                Console.WriteLine("Bubble Sort:");
                SortArray(numbersArray, SortType.BubbleSort);
            }
            else if (sortCheck == "merge" || sortCheck == "mergesort" || sortCheck == "2")
            {
                Console.WriteLine("Merge Sort:");
                SortArray(numbersArray, SortType.MergeSort);
            }
            else if (sortCheck == ".net" || sortCheck == ".netsort" || sortCheck == "net" || sortCheck == "netsort" || sortCheck == "3")
            {
                Console.WriteLine(".NET Sort:");
                SortArray(numbersArray, SortType.DotNETSort);
            }
        }

        private string DisplayRandomArray(int[] randomNumbers)
        {
            string randomArray = "";

            foreach (int num in randomNumbers)
            {
                randomArray += num + " ";
            }

            return randomArray;
        }

        private void SortArray(int[] numbers, SortType sortType)
        {
            var sorting = controller.SortSelection(sortType);

            int[] result = sorting.SortArray(numbers);

            string resultOutput = "";

            foreach (int num in result)
            {
                resultOutput += num + " ";
            }

            DisplaySortedArrayMenu(resultOutput);
        }

        private void DisplaySortedArrayMenu(string resultOutput)
        {
            Console.WriteLine("Sorted Array: " + resultOutput.Trim());

            Console.WriteLine();

            Console.WriteLine("Would you like to sort another Array?");
            Console.WriteLine("Yes[Y], Menu[M], Exit[E]");
            string userInput = Console.ReadLine().ToLower().Replace(" ", "");

            if (userInput == "y")
            {
                ArrayCreationMenu();
            }
            else if (userInput == "m")
            {
                MainMenu();
            }
            else if (userInput == "e")
            {
                Environment.Exit(0);
            }
        }

        private void UserInputHelpMenu()
        {
            SortingAppHeader();

            Console.WriteLine("Accepted User Inputs");
            Console.WriteLine("Letter Case and Spaces do not matter with the commands.");
            Console.WriteLine();

            Console.WriteLine("Main Menu:");
            Console.WriteLine();
            Console.WriteLine("Yes:");
            Console.WriteLine("- Y");
            Console.WriteLine("- y");
            Console.WriteLine();

            Console.WriteLine("Help:");
            Console.WriteLine("- H");
            Console.WriteLine("- h");
            Console.WriteLine();

            Console.WriteLine("Exit:");
            Console.WriteLine("- E");
            Console.WriteLine("- e");
            Console.WriteLine();

            Console.WriteLine("Array Creation Menu:");
            Console.WriteLine();

            Console.WriteLine("Create:");
            Console.WriteLine("- C");
            Console.WriteLine("- c");

            Console.WriteLine("Random:");
            Console.WriteLine("- R");
            Console.WriteLine("- r");
            Console.WriteLine();

            Console.WriteLine("Sort Algorithm Menu:");
            Console.WriteLine();

            Console.WriteLine("Main Menu:");
            Console.WriteLine("- 0");
            Console.WriteLine("- main menu");
            Console.WriteLine("- menu");
            Console.WriteLine("- main");

            Console.WriteLine("Bubble Sort:");
            Console.WriteLine("- 1");
            Console.WriteLine("- bubble");
            Console.WriteLine("- bubblesort");
            Console.WriteLine("- bubble sort");

            Console.WriteLine("Merge Sort:");
            Console.WriteLine("- 2");
            Console.WriteLine("- merge");
            Console.WriteLine("- mergesort");
            Console.WriteLine("- merge sort");

            Console.WriteLine(".Net Sort:");
            Console.WriteLine("- 3");
            Console.WriteLine("- net");
            Console.WriteLine("- .net");
            Console.WriteLine("- .netsort");
            Console.WriteLine("- .netsort");
            Console.WriteLine();

            Console.WriteLine("Display Sorted Array Menu:");
            Console.WriteLine();

            Console.WriteLine("Yes:");
            Console.WriteLine("- Y");
            Console.WriteLine("- y");

            Console.WriteLine("Main Menu:");
            Console.WriteLine("- main menu");
            Console.WriteLine("- menu");
            Console.WriteLine("- main");

            Console.WriteLine("Exit:");
            Console.WriteLine("- E");
            Console.WriteLine("- e");
            Console.WriteLine();

            Console.WriteLine("Help Menu:");
            Console.WriteLine();
            Console.WriteLine("- menu");
            Console.WriteLine("- main");
            Console.WriteLine("- mainmenu");
            Console.WriteLine();

            Console.WriteLine("return to Main Menu:");
            string userInput = Console.ReadLine().ToLower().Replace(" ", "");

            if (userInput == "menu" || userInput == "main" || userInput == "mainmenu")
            {
                MainMenu();
            }
            Console.WriteLine();
        }
    }
}
