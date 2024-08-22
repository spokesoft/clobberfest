using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;

namespace Spokesoft.Clobberfest.Common.Extensions.Logging
{
    public static class LoggingExtensions
    {
        public static void AddLogging(this IHostApplicationBuilder host)
        {
            host.Services.AddLogging(_AddLogging);
        }

        private static void _AddLogging(ILoggingBuilder builder)
        {
            builder.ClearProviders();
            builder.SetMinimumLevel(LogLevel.Trace);
            builder.AddNLog();
        }
    }
}