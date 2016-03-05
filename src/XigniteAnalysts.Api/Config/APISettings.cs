using System.Configuration;
using XigniteAnalysts.Infrastructure.Config;

namespace XigniteAnalysts.Api.Config
{
	public class ApiSettings : LazySingleConfigurationSection
	{
		public static ApiSettings Instance
		{
			get { return GetInstaces<ApiSettings>(); }
		}

		[ConfigurationProperty("ApiToken", IsRequired = true)]
		public string ApiToken 
		{
			get { return this["ApiToken"] as string; }
		}

		[ConfigurationProperty("XigniteAnalystsServiceUrl", IsRequired = true)]
		public string XigniteAnalystsServiceUrl
		{
			get { return this["XigniteAnalystsServiceUrl"] as string;}
		}

		[DefaultSettingValue("false")]
		[ConfigurationProperty("IgnoreInvalidCertificates", IsRequired = false)]
		public bool IgnoreInvalidCertificates
		{
			get { return (bool)this["IgnoreInvalidCertificates"]; }
		}
	}
}
