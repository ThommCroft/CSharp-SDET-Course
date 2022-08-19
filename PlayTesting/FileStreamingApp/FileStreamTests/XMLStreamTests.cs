namespace FileStreamTests
{
    public class XMLStreamTests
    {
        public readonly string xmlFileName = "XMLFile.xml";

        private static readonly string _path = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..");

        [Test]
        [Category("XML Happy Path")]
        public void GivenAFile_SerialiseAndDesialiseToXML_ReturnGivenMessage()
        {
            var givenMessage = new FileForStreaming();
            givenMessage.FileText = "This is an XML File";


            XMLStream xmlStream = new XMLStream();
            xmlStream.SerialiseToFile($"{_path}/{xmlFileName}", givenMessage);

            var deserialisedMessage = xmlStream.DeserialiseFromFile<FileForStreaming>($"{_path}/{xmlFileName}");

            Assert.That(deserialisedMessage.FileText, Is.EqualTo(givenMessage.FileText));
        }
    }
}
