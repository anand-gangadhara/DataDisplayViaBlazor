using DisplayData.Entities;
using DisplayData.Services;
using DisplayData.Wrappers;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DisplayData.Tests
{
    public class DisplayDataTest
    {       
        [Test]
        public async Task Given_Xml_File_Exist_In_Path_When_File_Is_Read_Then_It_Should_Return_Valid_Count_Of_ScenariosAsync()
        {
            //Arrange
            var mockFileIO = new Mock<IFileIO>();
            var mockXmlDeserializer = new Mock<IXmlDeserializer>();
            var xmlService = new XmlService(mockFileIO.Object, mockXmlDeserializer.Object);
            var dataList = new Entities.Data { Scenarios = new List<Scenario> { new Scenario { ScenarioID = 1 } } };

            mockFileIO.Setup(x => x.Open(It.IsAny<string>(), System.IO.FileMode.Open)).Returns(new System.IO.FileStream("TestData.xml", System.IO.FileMode.Open));
            mockXmlDeserializer.Setup(x => x.Deserialize(It.IsAny<System.IO.FileStream>())).ReturnsAsync(dataList);

            //Act
            var data = await xmlService.ReadXmlDataFromFile("SomePath");

            //Assert
            Assert.AreEqual(data.Scenarios.Count, 1);
        }
    }
}