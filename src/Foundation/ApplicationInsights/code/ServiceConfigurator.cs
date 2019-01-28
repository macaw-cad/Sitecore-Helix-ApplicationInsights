using Microsoft.ApplicationInsights.Extensibility;
using Microsoft.Extensions.DependencyInjection;
using Sitecore;
using Sitecore.DependencyInjection;

namespace Foundation.Macaw.ApplicationInsights
{
    public class ServiceConfigurator : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            if (!MainUtil.GetBool(System.Configuration.ConfigurationManager.AppSettings.Get("AppInsights:enabled"), true))
            {
                TelemetryConfiguration.Active.DisableTelemetry = true;
            }

            //makes it persist instant
            TelemetryConfiguration.Active.TelemetryChannel.DeveloperMode = IsDebug;
        }

        public static bool IsDebug =>
#if DEBUG
            true;

#else
            return false;
#endif
    }
}