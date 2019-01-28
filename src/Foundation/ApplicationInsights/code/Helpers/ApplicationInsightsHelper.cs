using Microsoft.ApplicationInsights.Extensibility;

namespace Foundation.Macaw.ApplicationInsights.Helpers
{
    public static class ApplicationInsightsHelper
    {
        public static string GetInstrumentalKey()
        {
            return TelemetryConfiguration.Active.InstrumentationKey;
        }
    }
}