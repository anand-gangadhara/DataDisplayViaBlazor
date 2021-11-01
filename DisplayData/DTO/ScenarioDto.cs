using System;
using System.Collections.Generic;

namespace DisplayData.DTO
{
    public class ScenarioDto
	{
		public int ScenarioID { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public string Forename { get; set; }

		public string UserID { get; set; }
		public DateTime SampleDate { get; set; }
		public string CreationDate { get; set; }

		public int NumMonths { get; set; }

		public int MarketID { get; set; }

		public int NetworkLayerID { get; set; }
	}

	public class DataDto
	{
		public List<ScenarioDto> Scenarios { get; set; }
	}
}
