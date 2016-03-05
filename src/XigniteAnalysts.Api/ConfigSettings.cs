using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XigniteAnalysts.Api
{
	public class ConfigSettings
	{
		public static string GetConfigSettingStr(string key)
		{
			var value = ConfigurationManager.AppSettings[key];
			return value.ToString(CultureInfo.InvariantCulture);
		}
	}
}
