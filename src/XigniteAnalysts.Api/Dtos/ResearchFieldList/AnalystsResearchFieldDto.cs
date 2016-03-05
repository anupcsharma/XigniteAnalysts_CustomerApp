namespace XigniteAnalysts.Api.Dtos.ResearchFieldList
{
	public class AnalystsResearchFieldDto
	{
		//public SecurityDto Security;

		public AnalystFieldTypes FieldType { get; set; }

		public string Description { get; set; }

		public string Value { get; set; }

		public string DataType { get; set; }

		public string DataFormat { get; set; }

		public string DataSource { get; set; }
	}
}
