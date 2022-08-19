using FileStreamController;

namespace FileStreamApp
{
    public class FileStreamMenus
    {
        private Controller _controller;

        public void FileStreamHeader()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine("File Stream");
            Console.WriteLine("-----------");

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine();
        }

        public void MainMenu()
        {
            _controller = new Controller();

            FileStreamHeader();

            Console.WriteLine("Main Menu");

            Console.WriteLine("Would you like to create a file? [Y] [E]");
            var userInput = Console.ReadLine().ToLower().Replace(" ", "");

            if (userInput == "y")
            {
                CreateAFileMenu();
            }
            else if (userInput == "e")
            {
                Environment.Exit(0);
            }
        }

        public void CreateAFileMenu()
        {
            FileStreamHeader();

            Console.WriteLine("Create a File");

            Console.WriteLine("Enter text that you want saving to a file: ");
            Console.WriteLine("Press Enter twice when you are finished.");

            string userInput = Console.ReadLine();
            _controller.ForStreaming.FileText = userInput;

            var enterKey = Console.ReadKey();

            if (enterKey.Key == ConsoleKey.Enter)
            {
                FileStreamChoiceMenu();
            }
        }

        public void FileStreamChoiceMenu()
        {
            FileStreamHeader();

            Console.WriteLine("File Stream Choice");

            Console.WriteLine("Please choose the Stream type for your file: ");
            Console.WriteLine("1. Binary");
            Console.WriteLine("2. XML");
            Console.WriteLine("3. JSON");

            string userInput = Console.ReadLine().ToLower().Replace(" ", "");

            if (userInput == "1")
            {
                _controller.SelectFileStreamType(0);
                _controller.SerialiseFile(_controller.binaryFileName);

                OpenFileFromFolderMenu();
            }
            else if (userInput == "2")
            {
                _controller.SelectFileStreamType(1);
                _controller.SerialiseFile(_controller.xmlFileName);

                OpenFileFromFolderMenu();
            }
            else if (userInput == "3")
            {
                _controller.SelectFileStreamType(2);
                _controller.SerialiseFile(_controller.jsonFileName);

                OpenFileFromFolderMenu();
            }
        }

        public void OpenFileFromFolderMenu()
        {
            FileStreamHeader();

            Console.WriteLine("Open Saved File");
            Console.WriteLine("Open File[O] Main Menu[M]");

            string userInput = Console.ReadLine().ToLower().Replace(" ", "");

            if (userInput == "o")
            {
                var fileContent = _controller.CheckFileType();

                Console.WriteLine(fileContent.FileText);
            }
            else if (userInput == "m")
            {
                MainMenu();
            }
        }
    }
}
