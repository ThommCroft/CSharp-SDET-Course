namespace FileStreamModel
{
    public enum StreamType { Binary, XML, JSON }

    public interface IStream
    {
        public StreamType Stream { get; }

        void SerialiseToFile<T>(string filePath, T item);

        T DeserialiseFromFile<T>(string filePath);
    }
}
