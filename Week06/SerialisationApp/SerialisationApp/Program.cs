namespace SerialisationApp
{
    public class Program
    {
        // Example Path:
        //private static readonly string _path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        private static readonly string _path = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..");
        private static ISerialise? _serialiser;

        static void Main(string[] args)
        {
            // variable? is the same as Nullable.
            
            Trainee trainee = new Trainee() { FirstName = "Dylan", LastName = "Cole", SpartaNumber = 100 };

            // Binary Serialise
            _serialiser = new SerialiserBinary();
            _serialiser.SerialiseToFile($"{_path}/BinaryTrainee.bin", trainee);
            //binarySerialiser.SerialiseToFile<Trainee>($"{_path}/BinaryTrainee.bin", trainee); // an alternate way to use the method.

            Trainee deserialisedBinaryDylan = _serialiser.DeserialiseFromFile<Trainee>($"{_path}/BinaryTrainee.bin");

            if (trainee == deserialisedBinaryDylan)
            {
                Console.WriteLine("Welcome back");
            }
            else
            {
                Console.WriteLine("Imposter!!");
                Console.WriteLine(deserialisedBinaryDylan);
            }

            // Course
            var eng120 = new Course();
            eng120.AddTrainee(trainee);
            eng120.AddTrainee(new Trainee { FirstName = "Tom", LastName = "Wolstencroft", SpartaNumber = 101 });

            // JSON Serialise
            _serialiser = new SerialiserJSON();
            _serialiser.SerialiseToFile($"{_path}/JSONTrainee.json", trainee);
            Trainee deserialisedJSONDylan = _serialiser.DeserialiseFromFile<Trainee>($"{_path}/JSONTrainee.json");

            Console.WriteLine(deserialisedJSONDylan);

            _serialiser.SerialiseToFile($"{_path}/JSONCourse.json", eng120);
            Course deserialisedJSONCourse = _serialiser.DeserialiseFromFile<Course>($"{_path}/JSONCourse.json");

            Console.WriteLine(deserialisedJSONCourse);

            // XML Serialise
            _serialiser = new SerialiserXML();
            _serialiser.SerialiseToFile($"{_path}/XMLTrainee.xml", trainee);
            Trainee deserialisedXMLDylan = _serialiser.DeserialiseFromFile<Trainee>($"{_path}/XMLTrainee.xml");

            Console.WriteLine(deserialisedXMLDylan);

            _serialiser.SerialiseToFile($"{_path}/XMLCourse.xml", eng120);
            var deserialisedCourse = _serialiser.DeserialiseFromFile<Course>($"{_path}/XMLCourse.xml");

            Console.WriteLine(deserialisedCourse);
        }
    }
}