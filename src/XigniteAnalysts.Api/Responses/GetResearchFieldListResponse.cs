using System.Collections.Generic;
using XigniteAnalysts.Api.Dtos.ResearchFieldList;
using XigniteAnalysts.Api.XigniteAnalystsServiceReference;

namespace XigniteAnalysts.Api.Responses
{
	public class GetResearchFieldListResponse : Response
	{
		public SecurityDto Security { get; set; }
		public List<AnalystsResearchFieldDto> AnalystsResearchFields { get; set; }
	}
}
