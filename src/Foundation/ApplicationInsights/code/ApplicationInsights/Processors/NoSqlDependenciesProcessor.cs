using Microsoft.ApplicationInsights.Channel;
using Microsoft.ApplicationInsights.DataContracts;
using Microsoft.ApplicationInsights.Extensibility;

namespace Foundation.Macaw.ApplicationInsights.ApplicationInsights.Processors
{
    public class NoSqlDependenciesProcessor : ITelemetryProcessor
    {
        private ITelemetryProcessor Next { get; set; }

        public NoSqlDependenciesProcessor(ITelemetryProcessor next)
        {
            this.Next = next;
        }

        public void Process(ITelemetry item)
        {
            if (IsSQLDependency(item))
                return;
            this.Next.Process(item);
        }

        private bool IsSQLDependency(ITelemetry item)
        {
            var dependency = item as DependencyTelemetry;
            switch (dependency?.Type)
            {
                case null:
                    return false;

                case "SQL":
                    return true;

                default:
                    return false;
            }
        }
    }
}