using FileStreamModel;

namespace FileStreamController
{
    public class Controller
    {
        public readonly string binaryFileName = "BinaryFile.bin";
        public readonly string xmlFileName = "XMLFile.xml";
        public readonly string jsonFileName = "JSONFile.json";

        private static readonly string _path = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..");
        private IStream _stream;

        public FileForStreaming ForStreaming { get; set; } = new FileForStreaming();

        public void SelectFileStreamType(int streamType)
        {
            switch (streamType)
            {
                case (int)StreamType.Binary:
                    _stream = new BinaryStream();
                    break;
               case (int)StreamType.XML:
                    _stream = new XMLStream();
                    break;
                case (int)StreamType.JSON:
                    _stream = new JSONStream();
                    break;
            }
        }

        public void SerialiseFile(string fileName)
        {
            _stream.SerialiseToFile($"{_path}/{fileName}", ForStreaming);
        }

        public FileForStreaming CheckFileType()
        {
            FileForStreaming file = new FileForStreaming();

            if (_stream.Stream == StreamType.Binary)
            {
                file = DeserialiseFile(binaryFileName);
            }
            else if (_stream.Stream == StreamType.XML)
            {
                file = DeserialiseFile(xmlFileName);
            }
            else if (_stream.Stream == StreamType.JSON)
            {
                file = DeserialiseFile(jsonFileName);
            }

            return file;
        }

        private FileForStreaming DeserialiseFile(string fileName)
        {
            FileForStreaming deserialisedFile = _stream.DeserialiseFromFile<FileForStreaming>($"{_path}/{fileName}");

            return deserialisedFile;
        }
    }
}