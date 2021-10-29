using DisplayData.Wrappers;
using System.IO;
using System.Threading.Tasks;

namespace DisplayData.Services
{
    public class XmlService
    {
        private readonly IFileIO fileIO;
        private readonly IXmlDeserializer xmlDeSerializer;

        public XmlService(IFileIO fileIO, IXmlDeserializer xmlSerializer)
        {
            this.fileIO = fileIO;
            this.xmlDeSerializer = xmlSerializer;
        }
      

        public async Task<Entities.Data> ReadXmlDataFromFile(string filePath)
        {
            using (var fileStream = this.fileIO.Open(filePath, FileMode.Open))
            {
                return  (Entities.Data) await xmlDeSerializer.Deserialize(fileStream);               
            }
        }
    }
}
