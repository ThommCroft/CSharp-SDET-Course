namespace FileStreamTests
{
    public class BinaryStreamTests
    {
        public readonly string binaryFileName = "BinaryFile.bin";

        private static readonly string _path = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..");

        [Test]
        [Category("Binary Happy Path")]
        public void GivenAFile_SerialiseAndDesialiseToBinary_ReturnGivenMessage()
        {
            var givenMessage = new FileForStreaming();
            givenMessage.FileText = "This is a JSON File";


            BinaryStream binaryStream = new BinaryStream();
            binaryStream.SerialiseToFile($"{_path}/{binaryFileName}", givenMessage);

            var deserialisedMessage = binaryStream.DeserialiseFromFile<FileForStreaming>($"{_path}/{binaryFileName}");

            Assert.That(deserialisedMessage.FileText, Is.EqualTo(givenMessage.FileText));
        }
    }
}