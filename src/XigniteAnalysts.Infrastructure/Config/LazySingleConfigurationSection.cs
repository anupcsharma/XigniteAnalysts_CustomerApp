using System;
using System.Collections.Generic;
using System.Configuration;
using System.Web.Configuration;

namespace XigniteAnalysts.Infrastructure.Config
{
	public abstract class LazySingleConfigurationSection : ConfigurationSection
	{
		private static readonly Dictionary<Type, LazySingleConfigurationSection>  instances = 
			new Dictionary<Type, LazySingleConfigurationSection>();

		private static readonly object syncObject = new object();

		protected static T GetInstaces<T>()
			where T : LazySingleConfigurationSection
		{
			var type = typeof (T);
			if (instances.ContainsKey(type))
			{
				return (T)instances[type];
			}

			lock (syncObject)
			{
				if (instances.ContainsKey(type))
				{
					return (T) instances[type];
				}

				var config = LoadSection<T>();
				if(config == null)
				{
					return null;
				}
				instances.Add(type, config);
				return config;
			}
		}

		public static T LoadSection<T>()
			where T : ConfigurationSection
		{
			return (T) LoadConfiguration().GetSection(typeof (T).Name);
		}

		private static Configuration LoadConfiguration()
		{
			return WebConfigurationManager.OpenWebConfiguration("~/");
		}
	}
}
