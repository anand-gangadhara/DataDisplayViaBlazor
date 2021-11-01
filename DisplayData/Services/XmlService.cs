using DisplayData.DTO;
using DisplayData.Wrappers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
      

        public async Task<IEnumerable<ScenarioDto>> ReadXmlDataFromFile(string filePath)
        {
            using (var fileStream = this.fileIO.Open(filePath, FileMode.Open))
            {
                var result = (Entities.Data) await xmlDeSerializer.Deserialize(fileStream);
                return result.Scenarios.Select(x => new ScenarioDto
                {
                    ScenarioID = x.ScenarioID,
                    Name = x.Name,
                    Surname = x.Surname,
                    Forename = x.Forename,
                     UserID = x.UserID,
                    SampleDate = DateTimeOffset.Parse(x.SampleDate).DateTime,
                    CreationDate = x.CreationDate,
                    NumMonths=x.NumMonths,
                    MarketID=x.MarketID,
                    NetworkLayerID=x.NetworkLayerID
                }).ToList(); 
            }
        }
    }
}
