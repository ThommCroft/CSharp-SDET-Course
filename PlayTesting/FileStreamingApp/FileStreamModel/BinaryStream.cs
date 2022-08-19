using System.Runtime.Serialization.Formatters.Binary;

namespace FileStreamModel
{
    public class BinaryStream : IStream
    {
        public StreamType Stream { get; } = StreamType.Binary;

        public void SerialiseToFile<T>(string filePath, T item)
        {
            FileStream fileStream = File.Create(filePath);
            BinaryFormatter writer = new BinaryFormatter();

            writer.Serialize(fileStream, item); // Obsolete (Security Issues, recommends JSON or XML)

            fileStream.Close();
        }

        public T DeserialiseFromFile<T>(string filePath)
        {
            Stream fileStream = File.OpenRead(filePath);
            BinaryFormatter reader = new BinaryFormatter();

            var deserialiseItem = (T)reader.Deserialize(fileStream);

            fileStream.Close();

            return deserialiseItem;
        }
    }
}