using System.Collections.Generic;
using XigniteAnalysts.Api.Dtos.ResearchFieldList;

namespace XigniteAnalysts.Web.ViewModels
{
	public class ResearchFieldListViewModel
	{
		public SecurityDto Security { get; set; }
		public List<AnalystsResearchFieldDto> AnalystsResearchFields { get; set; }
	}
}