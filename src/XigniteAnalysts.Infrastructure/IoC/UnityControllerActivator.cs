using System;
using System.Web.Mvc;
using System.Web.Routing;
using Microsoft.Practices.Unity;

namespace XigniteAnalysts.Infrastructure.IoC
{
	public class UnityControllerActivator : IControllerActivator
	{
		public IUnityContainer Container;

		public UnityControllerActivator(IUnityContainer container)
		{
			Container = container;
		}

		public IController Create(RequestContext requestContext, Type controllerType)
		{
			var controller = Activator.CreateInstance(controllerType);
			return Container.BuildUp(controllerType, controller) as IController;
		}
	}
}
