using System.Threading.Tasks;
using XigniteAnalysts.Api.Config;
using XigniteAnalysts.Api.Repository.Interfaces;
using XigniteAnalysts.Api.XigniteAnalystsServiceReference;

namespace XigniteAnalysts.Api.Repository
{
	public class XigniteAnalystsRepository : IXigniteAnalystsRepository
	{
		public async Task<XigniteAnalystsServiceReference.GetResearchFieldListResponse> GetResearchFieldList(string identifier)
		{
			var request = new GetResearchFieldListRequest
			{
				Header = new Header {Username = ApiSettings.Instance.ApiToken},
				AnalysisGroup = AnalysisGroups.CurrentSalesConsensus,
				IdentifierType = IdentifierTypes.Symbol,
				Identifier = !(string.IsNullOrEmpty(identifier)) ? identifier : "MSFT"
			};
			var response = await XigniteApiClient.GetResponse(request, (c) => c.GetResearchFieldListAsync(request.Header, request.Identifier, request.IdentifierType, request.AnalysisGroup));
			return response;
		}
	}
}
