using System;
using System.Reflection;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using XigniteAnalysts.Infrastructure;
using XigniteAnalysts.Infrastructure.IoC;

namespace XigniteAnalysts.Web
{
	public class MvcApplication : UnityHttpApplication
	{
		protected override void Application_Start()
		{
			base.Application_Start();
			//AreaRegistration.RegisterAllAreas();
			//FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
			//RouteConfig.RegisterRoutes(RouteTable.Routes);
			//BundleConfig.RegisterBundles(BundleTable.Bundles);
			AutoMapperBootstrapper.Execute(Assembly.GetCallingAssembly());
		}

		protected override void RegisterRoutes(RouteCollection routes)
		{
			RouteConfig.RegisterRoutes(RouteTable.Routes);
		}

		protected override void OnError(Exception ex)
		{
			//throw new NotImplementedException();
		}
	}
}
