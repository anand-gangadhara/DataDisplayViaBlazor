using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace DisplayData.Entities
{
	[XmlRoot(ElementName = "Scenario")]
	public class Scenario
	{

		[XmlElement(ElementName = "ScenarioID")]
		public int ScenarioID { get; set; }

		[XmlElement(ElementName = "Name")]
		public string Name { get; set; }

		[XmlElement(ElementName = "Surname")]
		public string Surname { get; set; }

		[XmlElement(ElementName = "Forename")]
		public string Forename { get; set; }

		[XmlElement(ElementName = "UserID")]
		public string UserID { get; set; }

		[XmlElement(ElementName = "SampleDate")]
		public string SampleDate { get; set; }

		[XmlElement(ElementName = "CreationDate")]
		public string CreationDate { get; set; }

		[XmlElement(ElementName = "NumMonths")]
		public int NumMonths { get; set; }

		[XmlElement(ElementName = "MarketID")]
		public int MarketID { get; set; }

		[XmlElement(ElementName = "NetworkLayerID")]
		public int NetworkLayerID { get; set; }
	}

	[XmlRoot(ElementName = "Data")]
	public class Data
	{
		[XmlElement(ElementName = "Scenario")]
		public List<Scenario> Scenarios { get; set; }
    }

}
