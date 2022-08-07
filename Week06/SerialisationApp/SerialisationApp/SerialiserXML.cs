using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerialisationApp
{
    internal class SerialiserXML : ISerialise
    {
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
