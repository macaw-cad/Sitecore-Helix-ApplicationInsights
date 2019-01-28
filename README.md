Foundation.Macaw.ApplicationInsights
===



## About this module
This module enables ApplciationInsights for Onpremise versions of Sitecore 9.0.2 by appending the same structure as the PAAS version has. 

Also 2 new processors/initializers are added to add extra information for better analyzing:

- ApplicationVersionInitializer  -> appends the dll version
- NoSqlDependenciesProcessor -> for filtering unnecessary SQL dependency logging. 


## Remarks and use cases
Disable the telemetry local for better performance by adding this entry to your web.config 

```xml
<add key="AppInsights:enabled" value="false" />
```

Added role configuration so its better to distinquish calls to CM or CD by 2 configs:

- zSitecore.Cloud.ApplicationInsights.CD.config
- zSitecore.Cloud.ApplicationInsights.CM.config

