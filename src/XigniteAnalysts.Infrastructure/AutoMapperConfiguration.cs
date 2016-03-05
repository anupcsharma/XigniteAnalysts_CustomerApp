using System;
using System.Linq;
using System.Reflection;
using AutoMapper;

namespace XigniteAnalysts.Infrastructure
{
	public class AutoMapperBootstrapper
	{
		public static void Execute(Assembly assemblyLoad)
		{
			Mapper.Reset();

			var assemblyNames = assemblyLoad.GetReferencedAssemblies();

			foreach (var assemblyName in assemblyNames)
			{
				var needToLoad = AppDomain.CurrentDomain
					.GetAssemblies()
					.Any(assembly => AssemblyName.ReferenceMatchesDefinition(
						assemblyName, assembly.GetName())) == false;

				if (needToLoad)
					Assembly.Load(assemblyName);
			}


			var profiles = AppDomain.CurrentDomain
				.GetAssemblies()
				.Where(assembly => assembly
					.GetCustomAttributes(typeof (AutoMappingProfilesContainerAttribute), true)
					.Any())
				.SelectMany(assembly => GetTypes(assembly)
					.Where(type => type.IsSubclassOf(typeof (Profile))));



			foreach (var instance in profiles.Select(profile => Activator.CreateInstance(profile) as Profile))
				Mapper.AddProfile(instance);
		}

		private static Type[] GetTypes(Assembly assembly)
		{
			return assembly.GetTypes();
		}
	}

	[AttributeUsage(AttributeTargets.Assembly)]
	public class AutoMappingProfilesContainerAttribute : Attribute
	{
	}
	
}

