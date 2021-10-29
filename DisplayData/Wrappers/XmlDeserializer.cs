using System.IO;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DisplayData.Wrappers
{
    public class XmlDeserializer : IXmlDeserializer
    {
        private XmlSerializer GetXmlSerializer()
        {
            return new XmlSerializer(typeof(Entities.Data));
        }

        public async Task<object> Deserialize(FileStream fileStream)
        {
            return await Task.Run(() => GetXmlSerializer().Deserialize(fileStream));
        }
    }
}
