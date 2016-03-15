using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Core.Objects;
using System.Reflection.Emit;
using AutoMapper;
using XigniteAnalysts.Api.Dtos.ResearchFieldList;
using XigniteAnalysts.Api.XigniteAnalystsServiceReference;
using XigniteAnalysts.Infrastructure;
using XigniteAnalysts.Web.ViewModels;
using AnalystFieldTypes = XigniteAnalysts.Api.Dtos.ResearchFieldList.AnalystFieldTypes;
using OutcomeTypes = XigniteAnalysts.Api.Dtos.ResearchFieldList.OutcomeTypes;

namespace XigniteAnalysts.Web.MapProfiles
{
	public class ToResearchFieldListViewModel : Profile
	{
		protected override void Configure()
		{
			CreateMap<GetResearchFieldListResponse, ResearchFieldListViewModel>()
				.ForMember(model => model.Security, model => model.Ignore())
				.AfterMap((src, dst) =>
				{
					if (src.GetResearchFieldListResult.Security != null)
						dst.Security = MapSecurity(src.GetResearchFieldListResult.Security);
				})
				.ForMember(model => model.AnalystsResearchFields, model => model.Ignore())
				.AfterMap((src, dst) =>
				{
					if (src.GetResearchFieldListResult.AnalystsResearchFields != null)
						dst.AnalystsResearchFields = MapAnalystsResearchFieldList(src.GetResearchFieldListResult.AnalystsResearchFields);
				})
				.ForMember(model => model.Delay, opt => opt.MapFrom(dto => dto.GetResearchFieldListResult.Delay))
				.ForMember(model => model.Identity, opt => opt.MapFrom(dto => dto.GetResearchFieldListResult.Identity))
				.ForMember(model => model.Message, opt => opt.MapFrom(dto => dto.GetResearchFieldListResult.Message))
				.ForMember(model => model.Outcome, opt => opt.MapFrom(dto => dto.GetResearchFieldListResult.Outcome))
				;
		}

		private SecurityDto MapSecurity(Security security)
		{
			return new SecurityDto
			{
				Delay = security.Delay,
				CIK = security.CIK,
				Cusip = security.Cusip,
				Symbol = security.Symbol,
				ISIN = security.ISIN,
				Valoren = security.Valoren,
				Name = security.Name,
				Market = security.Market,
				CategoryOrIndustry = security.CategoryOrIndustry,
				Outcome = (OutcomeTypes)security.Outcome
			};
		}

		
		private List<AnalystsResearchFieldDto> MapAnalystsResearchFieldList(IEnumerable<AnalystsResearchField> dto)
		{
			var analystsResearchFieldList = new List<AnalystsResearchFieldDto>();
			foreach (var item in dto)
			{
				var analystsResearchField = new AnalystsResearchFieldDto();
				analystsResearchField.DataFormat = item.DataFormat;
				analystsResearchField.DataSource = item.DataSource;
				analystsResearchField.DataType = item.DataType;
				analystsResearchField.Description = item.Description;
				analystsResearchField.Value = item.Value;
				analystsResearchField.FieldType = (AnalystFieldTypes)item.FieldType;
				analystsResearchFieldList.Add(analystsResearchField);
			}
			return analystsResearchFieldList;
		}
	}
}