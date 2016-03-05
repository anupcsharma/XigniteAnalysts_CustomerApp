using Microsoft.Practices.Unity;

namespace XigniteAnalysts.Infrastructure.IoC
{
	public abstract class ModuleRegistrator
	{
		[Dependency]
		public IUnityContainer Container { get; set; }

		public abstract void Run();
	}
}
