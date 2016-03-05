using System.ComponentModel.DataAnnotations;

namespace XigniteAnalysts.Web.ViewModels
{
	public class ResearchFieldListSearchViewModel
	{
		[Required]
		public string Identifier { get; set; }
	}
}