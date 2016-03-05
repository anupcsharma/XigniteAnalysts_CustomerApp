using Microsoft.Practices.Unity;
using XigniteAnalysts.Api.Config;
using XigniteAnalysts.Api.Repository;
using XigniteAnalysts.Api.Repository.Interfaces;
using XigniteAnalysts.Infrastructure.IoC;

namespace XigniteAnalysts.Api
{
	public class Registrator : ModuleRegistrator
	{
		public override void Run()
		{
			Container.RegisterType<IXigniteAnalystsRepository, XigniteAnalystsRepository>(
				new ContainerControlledLifetimeManager());

			System.Net.ServicePointManager.Expect100Continue = false;
			if (ApiSettings.Instance.IgnoreInvalidCertificates)
			{
				// We ignored error for self-signed certificates
				System.Net.ServicePointManager.ServerCertificateValidationCallback = (sender, certificate, chain, policyErrors) => true;
			}
		}
	}
}
