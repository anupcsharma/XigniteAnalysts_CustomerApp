using System.Collections.Generic;
using XigniteAnalysts.Api.Dtos.ResearchFieldList;

namespace XigniteAnalysts.Web.ViewModels
{
	public class ResearchFieldListViewModel
	{
		public double Delay { get; set; }
		public string Identity { get; set; }
		public string Message { get; set; }
		public OutcomeTypes Outcome { get; set; }
		public SecurityDto Security { get; set; }
		public List<AnalystsResearchFieldDto> AnalystsResearchFields { get; set; }
	}
}