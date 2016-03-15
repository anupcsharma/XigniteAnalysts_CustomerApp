using System.Configuration;
using System.Globalization;

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
