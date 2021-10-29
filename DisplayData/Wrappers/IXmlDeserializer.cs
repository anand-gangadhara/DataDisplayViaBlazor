using System.IO;
using System.Threading.Tasks;

namespace DisplayData.Wrappers
{
    public interface IXmlDeserializer
    {
        Task<object> Deserialize(FileStream fileStream);
    }
}