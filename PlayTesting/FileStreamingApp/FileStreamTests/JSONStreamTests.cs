namespace FileStreamTests
{
    public class JSONStreamTests
    {
        public readonly string jsonFileName = "JSONFile.json";

        private static readonly string _path = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..");

        [Test]
        [Category("JSON Happy Path")]
        public void GivenAFile_SerialiseThenDesirialiseToJSON_ReturnGivenMessage()
        {
            var givenMessage = new FileForStreaming();
            givenMessage.FileText = "This is a JSON File";


            JSONStream jsonStream = new JSONStream();
            jsonStream.SerialiseToFile($"{_path}/{jsonFileName}", givenMessage);

            var deserialisedMessage = jsonStream.DeserialiseFromFile<FileForStreaming>($"{_path}/{jsonFileName}");

            Assert.That(deserialisedMessage.FileText, Is.EqualTo(givenMessage.FileText));
        }
    }
}
