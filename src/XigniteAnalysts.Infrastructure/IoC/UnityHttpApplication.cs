using System;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Microsoft.Practices.Unity;

namespace XigniteAnalysts.Infrastructure.IoC
{
	public abstract class UnityHttpApplication : HttpApplication
	{
		private UnityBootstrapper bootstrapper;

		[Dependency]
		public IUnityContainer Container { get; set; }

		public override void Init()
		{
			base.Init();
			var container = DependencyResolver.Current.GetService<IUnityContainer>();
			container.BuildUp(this.GetType(), this);
		}

		protected virtual void Application_Start()
		{
			bootstrapper = new UnityBootstrapper();
			bootstrapper.Run();
			bootstrapper.Container.BuildUp(this.GetType(), this);

			RegisterGlobalFilters(GlobalFilters.Filters);
			RegisterRoutes(RouteTable.Routes);
		}

		protected abstract void RegisterRoutes(RouteCollection routes);
		protected abstract void OnError(Exception ex);
		
		private void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			//throw new System.NotImplementedException();
		}

		protected void Application_Error(object sender, EventArgs e)
		{
			Exception ex = Server.GetLastError();
			// check is it favicon request and ignore it
			if (ex == null ||
				(ex is HttpException && ((HttpException)ex).GetHttpCode() == 404 &&
				 ex.Message.IndexOf("favicon", StringComparison.OrdinalIgnoreCase) != -1))
			{
				return;
			}
			OnError(ex);
		}
	}
}
