using XigniteAnalysts.Api.XigniteAnalystsServiceReference;

namespace XigniteAnalysts.Api.Responses
{
	public interface IResponseDetail
	{
		OutcomeTypes Outcome { get; set; }
		string Message { get; set; }
		string Identity { get; set; }
		double Delay { get; set; }
	}
}
