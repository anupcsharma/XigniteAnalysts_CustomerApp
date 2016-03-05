namespace XigniteAnalysts.Api.Dtos.ResearchFieldList
{
	public enum OutcomeTypes
	{
		Success,
		SystemError,
		RequestError,
		RegistrationError,
	}

	public class SecurityDto
	{
		public OutcomeTypes Outcome { get; set; }
		public double Delay { get; set; }
		public string CIK { get; set; }
		public string Cusip { get; set; }
		public string Symbol { get; set; }
		public string ISIN { get; set; }
		public string Valoren { get; set; }
		public string Name { get; set; }
		public string Market { get; set; }
		public string CategoryOrIndustry { get; set; }
	}
}
