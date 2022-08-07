using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SerialisationApp
{
    internal class SerialiserBinary : ISerialise
    {
        // This type of class can implement a factory model which can have you choose between Binary, JSON, XML, etc.

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
