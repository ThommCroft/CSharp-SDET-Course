using System.Xml.Serialization;

namespace FileStreamModel
{
    public class XMLStream : IStream
    {
        public StreamType Stream { get; } = StreamType.XML;

        public void SerialiseToFile<T>(string filePath, T item)
        {
            FileStream fileStream = File.Create(filePath);
            XmlSerializer writer = new XmlSerializer(typeof(T));

            writer.Serialize(fileStream, item);
            fileStream.Close();
        }

        public T DeserialiseFromFile<T>(string filePath)
        {
            FileStream fileStream = File.OpenRead(filePath);
            XmlSerializer writer = new XmlSerializer(typeof(T));

            var deserialisedItem = (T)writer.Deserialize(fileStream);
            fileStream.Close();

            return deserialisedItem;
        }
    }
}
