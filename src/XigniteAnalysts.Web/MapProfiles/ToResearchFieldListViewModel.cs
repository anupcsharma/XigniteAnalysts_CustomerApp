using System.Collections.Generic;
using System.ComponentModel;
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
				//.ForMember(model => model.Security, opt => opt.MapFrom(dto => dto.GetResearchFieldListResult.Security))
				.ForMember(model => model.Security, opt => opt.ResolveUsing(x => new SecurityDto()
				{
					Delay = x.GetResearchFieldListResult.Security.Delay,
					CIK  = x.GetResearchFieldListResult.Security.CIK,
					Cusip  = x.GetResearchFieldListResult.Security.Cusip,
					Symbol = x.GetResearchFieldListResult.Security.Symbol,
					ISIN = x.GetResearchFieldListResult.Security.ISIN,
					Valoren = x.GetResearchFieldListResult.Security.Valoren,
					Name = x.GetResearchFieldListResult.Security.Name,
					Market = x.GetResearchFieldListResult.Security.Market,
					CategoryOrIndustry = x.GetResearchFieldListResult.Security.CategoryOrIndustry,
					Outcome = (OutcomeTypes) x.GetResearchFieldListResult.Security.Outcome
					
				}))
				//.IgnoreAllUnmapped()
				//.AfterMap(MapAnalystsResearchFieldList)
				.ForMember(model => model.AnalystsResearchFields, opt => opt.ResolveUsing(ResearchFieldListValuesResolver))
				;
				//.IgnoreAllUnmapped()
				//.ForMember(model => model.Security, opt => opt.MapFrom(dto => dto.GetResearchFieldListResult.Security))
				//.ForMember(model => model.AnalystsResearchFields, opt => opt.MapFrom(dto => dto.GetResearchFieldListResult.AnalystsResearchFields))
				
				;
		}

		private static List<AnalystsResearchFieldDto> ResearchFieldListValuesResolver(GetResearchFieldListResponse dto)
		{
			var analystsResearchFieldList = new List<AnalystsResearchFieldDto>();
			foreach (var item in dto.GetResearchFieldListResult.AnalystsResearchFields)
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

		private void MapAnalystsResearchFieldList(GetResearchFieldListResponse dto, ResearchFieldListViewModel model)
		{
			var analystsResearchFieldList = new List<AnalystsResearchFieldDto>();
			foreach (var item in dto.GetResearchFieldListResult.AnalystsResearchFields)
			{
				var analystsResearchField = new AnalystsResearchFieldDto();
				analystsResearchField.DataFormat = item.DataFormat;
				analystsResearchField.DataSource = item.DataSource;
				analystsResearchField.DataType = item.DataType;
				analystsResearchField.Description = item.Description;
				analystsResearchField.Value = item.Value;
				analystsResearchField.FieldType = (AnalystFieldTypes) item.FieldType;
				analystsResearchFieldList.Add(analystsResearchField);
			}
		}
	}
}