
using Microsoft.Extensions.Configuration;

namespace HitachiUiTest.UtilityHelper
{
    public class ConfigManager
    {
        public static string BrowsersType => new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
      .AddJsonFile("appsettings.json").Build().GetSection("Browsers")["Browser"];

        public static string WebSiteUrl => new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json").Build().GetSection("WebSiteUrl")["url"];
    }
}