using Microsoft.ApplicationInsights.Channel;
using Microsoft.ApplicationInsights.Extensibility;
using System.Reflection;

namespace Foundation.Macaw.ApplicationInsights.ApplicationInsights.Initializers
{
    public class ApplicationVersionInitializer : ITelemetryInitializer
    {
        public void Initialize(ITelemetry telemetry)
        {
            telemetry.Context.GlobalProperties["Version"] = Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }
    }
}