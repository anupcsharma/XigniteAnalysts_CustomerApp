using System.Threading.Tasks;
using XigniteAnalysts.Api.Responses;
using GetResearchFieldListResponse = XigniteAnalysts.Api.XigniteAnalystsServiceReference.GetResearchFieldListResponse;

namespace XigniteAnalysts.Api.Repository.Interfaces
{
	public interface IXigniteAnalystsRepository 
	{
		Task<GetResearchFieldListResponse> GetResearchFieldList(string identifier);
	}
}
