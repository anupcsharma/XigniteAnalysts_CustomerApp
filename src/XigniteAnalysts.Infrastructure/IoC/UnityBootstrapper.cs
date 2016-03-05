using System;
using System.Linq;
using System.Reflection;
using System.Web.Compilation;
using System.Web.Mvc;
using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Unity;

namespace XigniteAnalysts.Infrastructure.IoC
{
	public class UnityBootstrapper
	{
		internal IUnityContainer Container { get; set; }
		private readonly string targetNamespace;

		public UnityBootstrapper()
		{
			targetNamespace = typeof (UnityBootstrapper).FullName;
			targetNamespace = targetNamespace.Substring(0, targetNamespace.IndexOf('.'));
		}

		public void Run()
		{
			Container = new UnityContainer();
			DependencyResolver.SetResolver(new UnityDependencyResolver(Container));
			ServiceLocator.SetLocatorProvider(() => new UnityServiceLocator(Container));
			Container.RegisterType<IControllerActivator, UnityControllerActivator>();
			LoadModules();
		}

		private void LoadModules()
		{
			var assemblies = BuildManager.GetReferencedAssemblies().Cast<Assembly>().Where(IsItOurAssembly).ToList();
			var baseType = typeof (ModuleRegistrator);
			foreach (var assembly in assemblies)
			{
				foreach (var type in assembly.GetExportedTypes())
				{
					if (!type.IsAbstract && !type.IsInterface && baseType.IsAssignableFrom(type))
					{
						var moduleInitializer = (ModuleRegistrator) Activator.CreateInstance(type);
						Container.BuildUp(type, moduleInitializer);
						moduleInitializer.Run();
					}
				}
			}
		}

		private bool IsItOurAssembly(Assembly assembly)
		{
			return assembly.FullName.StartsWith(targetNamespace);
		}
	}
}
