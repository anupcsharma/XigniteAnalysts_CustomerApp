using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Microsoft.Practices.Unity;

namespace XigniteAnalysts.Infrastructure.IoC
{
	public class UnityDependencyResolver : IDependencyResolver
	{
		private readonly IUnityContainer _container;

		public UnityDependencyResolver(IUnityContainer container)
		{
			this._container = container;
		}

		public object GetService(Type serviceType)
		{
			return _container.IsRegistered(serviceType) ? _container.Resolve(serviceType) : null;
		}

		public IEnumerable<object> GetServices(Type serviceType)
		{
			return _container.ResolveAll(serviceType);
		}
	}
}
