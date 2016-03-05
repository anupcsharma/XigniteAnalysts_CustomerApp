using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Mvc;
using AutoMapper;
using Microsoft.Practices.Unity;
using XigniteAnalysts.Api.Repository.Interfaces;
using XigniteAnalysts.Api.XigniteAnalystsServiceReference;
using XigniteAnalysts.Web.ViewModels;

namespace XigniteAnalysts.Web.Controllers
{
	[System.Web.Mvc.RoutePrefix("")]
	public class HomeController : Controller
	{
		[Dependency]
		public IXigniteAnalystsRepository XigniteAnalystsRepository { get; set; }

		[System.Web.Mvc.HttpGet]
		[System.Web.Mvc.Route("")]
		public ActionResult Index()
		{
			return View();
		}

		[System.Web.Mvc.HttpPost]
		[System.Web.Mvc.Route("")]
		public async Task<ActionResult> Index(string identifier)
		{
			var viewModel = new ResearchFieldListViewModel();
			var researchFieldLists = await XigniteAnalystsRepository.GetResearchFieldList(identifier);
			
			viewModel = Mapper.Map<ResearchFieldListViewModel>(researchFieldLists);
			return View(viewModel);
		}
	}
}
