using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace Spokesoft.Clobberfest.Common.Extensions.Configuration
{
    public static class ConfigurationExtensions
    {
        public static void AddConfiguration(this IHostApplicationBuilder host)
        {
            var environmentName = host.Environment.EnvironmentName;
            host.Configuration.Sources.Clear();
            host.Configuration.AddJsonFile("config/appsettings.json", optional: false, reloadOnChange: true);
            host.Configuration.AddJsonFile("config/nlog.json", optional: false, reloadOnChange: true);
            host.Configuration.AddJsonFile($"config/appsettings.{environmentName}.json", optional: true, reloadOnChange: true);
        }
    }
}