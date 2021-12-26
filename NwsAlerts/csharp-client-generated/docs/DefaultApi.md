# IO.Swagger.Api.DefaultApi

All URIs are relative to *https://api.weather.gov*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AlertsActiveAreaAreaGet**](DefaultApi.md#alertsactiveareaareaget) | **GET** /alerts/active/area/{area} | 
[**AlertsActiveCountGet**](DefaultApi.md#alertsactivecountget) | **GET** /alerts/active/count | 
[**AlertsActiveGet**](DefaultApi.md#alertsactiveget) | **GET** /alerts/active | 
[**AlertsActiveRegionRegionGet**](DefaultApi.md#alertsactiveregionregionget) | **GET** /alerts/active/region/{region} | 
[**AlertsActiveZoneZoneIdGet**](DefaultApi.md#alertsactivezonezoneidget) | **GET** /alerts/active/zone/{zoneId} | 
[**AlertsGet**](DefaultApi.md#alertsget) | **GET** /alerts | 
[**AlertsIdGet**](DefaultApi.md#alertsidget) | **GET** /alerts/{id} | 
[**AlertsTypesGet**](DefaultApi.md#alertstypesget) | **GET** /alerts/types | 
[**GlossaryGet**](DefaultApi.md#glossaryget) | **GET** /glossary | 
[**GridpointsWfoXyForecastGet**](DefaultApi.md#gridpointswfoxyforecastget) | **GET** /gridpoints/{wfo}/{x},{y}/forecast | 
[**GridpointsWfoXyForecastHourlyGet**](DefaultApi.md#gridpointswfoxyforecasthourlyget) | **GET** /gridpoints/{wfo}/{x},{y}/forecast/hourly | 
[**GridpointsWfoXyGet**](DefaultApi.md#gridpointswfoxyget) | **GET** /gridpoints/{wfo}/{x},{y} | 
[**GridpointsWfoXyStationsGet**](DefaultApi.md#gridpointswfoxystationsget) | **GET** /gridpoints/{wfo}/{x},{y}/stations | 
[**IconsGet**](DefaultApi.md#iconsget) | **GET** /icons | 
[**IconsSetTimeOfDayFirstSecondGet**](DefaultApi.md#iconssettimeofdayfirstsecondget) | **GET** /icons/{set}/{timeOfDay}/{first}/{second} | 
[**OfficesOfficeIdGet**](DefaultApi.md#officesofficeidget) | **GET** /offices/{officeId} | 
[**OfficesOfficeIdHeadlinesGet**](DefaultApi.md#officesofficeidheadlinesget) | **GET** /offices/{officeId}/headlines | 
[**OfficesOfficeIdHeadlinesHeadlineIdGet**](DefaultApi.md#officesofficeidheadlinesheadlineidget) | **GET** /offices/{officeId}/headlines/{headlineId} | 
[**PointsPointForecastGet**](DefaultApi.md#pointspointforecastget) | **GET** /points/{point}/forecast | 
[**PointsPointForecastHourlyGet**](DefaultApi.md#pointspointforecasthourlyget) | **GET** /points/{point}/forecast/hourly | 
[**PointsPointGet**](DefaultApi.md#pointspointget) | **GET** /points/{point} | 
[**PointsPointStationsGet**](DefaultApi.md#pointspointstationsget) | **GET** /points/{point}/stations | 
[**ProductsGet**](DefaultApi.md#productsget) | **GET** /products | 
[**ProductsLocationsGet**](DefaultApi.md#productslocationsget) | **GET** /products/locations | 
[**ProductsLocationsLocationIdTypesGet**](DefaultApi.md#productslocationslocationidtypesget) | **GET** /products/locations/{locationId}/types | 
[**ProductsProductIdGet**](DefaultApi.md#productsproductidget) | **GET** /products/{productId} | 
[**ProductsTypesGet**](DefaultApi.md#productstypesget) | **GET** /products/types | 
[**ProductsTypesTypeIdGet**](DefaultApi.md#productstypestypeidget) | **GET** /products/types/{typeId} | 
[**ProductsTypesTypeIdLocationsGet**](DefaultApi.md#productstypestypeidlocationsget) | **GET** /products/types/{typeId}/locations | 
[**ProductsTypesTypeIdLocationsLocationIdGet**](DefaultApi.md#productstypestypeidlocationslocationidget) | **GET** /products/types/{typeId}/locations/{locationId} | 
[**RadarProfilersStationIdGet**](DefaultApi.md#radarprofilersstationidget) | **GET** /radar/profilers/{stationId} | 
[**RadarQueuesHostGet**](DefaultApi.md#radarqueueshostget) | **GET** /radar/queues/{host} | 
[**RadarServersGet**](DefaultApi.md#radarserversget) | **GET** /radar/servers | 
[**RadarServersIdGet**](DefaultApi.md#radarserversidget) | **GET** /radar/servers/{id} | 
[**RadarStationsGet**](DefaultApi.md#radarstationsget) | **GET** /radar/stations | 
[**RadarStationsStationIdAlarmsGet**](DefaultApi.md#radarstationsstationidalarmsget) | **GET** /radar/stations/{stationId}/alarms | 
[**RadarStationsStationIdGet**](DefaultApi.md#radarstationsstationidget) | **GET** /radar/stations/{stationId} | 
[**StationsGet**](DefaultApi.md#stationsget) | **GET** /stations | 
[**StationsStationIdGet**](DefaultApi.md#stationsstationidget) | **GET** /stations/{stationId} | 
[**StationsStationIdObservationsCurrentGet**](DefaultApi.md#stationsstationidobservationscurrentget) | **GET** /stations/{stationId}/observations/current | 
[**StationsStationIdObservationsGet**](DefaultApi.md#stationsstationidobservationsget) | **GET** /stations/{stationId}/observations | 
[**StationsStationIdObservationsLatestGet**](DefaultApi.md#stationsstationidobservationslatestget) | **GET** /stations/{stationId}/observations/latest | 
[**StationsStationIdObservationsTimeGet**](DefaultApi.md#stationsstationidobservationstimeget) | **GET** /stations/{stationId}/observations/{time} | 
[**ThumbnailsSatelliteAreaGet**](DefaultApi.md#thumbnailssatelliteareaget) | **GET** /thumbnails/satellite/{area} | 
[**ZonesForecastZoneIdObservationsGet**](DefaultApi.md#zonesforecastzoneidobservationsget) | **GET** /zones/forecast/{zoneId}/observations | 
[**ZonesForecastZoneIdStationsGet**](DefaultApi.md#zonesforecastzoneidstationsget) | **GET** /zones/forecast/{zoneId}/stations | 
[**ZonesGet**](DefaultApi.md#zonesget) | **GET** /zones | 
[**ZonesTypeGet**](DefaultApi.md#zonestypeget) | **GET** /zones/{type} | 
[**ZonesTypeZoneIdForecastGet**](DefaultApi.md#zonestypezoneidforecastget) | **GET** /zones/{type}/{zoneId}/forecast | 
[**ZonesTypeZoneIdGet**](DefaultApi.md#zonestypezoneidget) | **GET** /zones/{type}/{zoneId} | 

<a name="alertsactiveareaareaget"></a>
# **AlertsActiveAreaAreaGet**
> void AlertsActiveAreaAreaGet (string area)



Returns active alerts for the given area (state or marine area)

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AlertsActiveAreaAreaGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var area = area_example;  // string | 

            try
            {
                apiInstance.AlertsActiveAreaAreaGet(area);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.AlertsActiveAreaAreaGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **area** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/geo+json, application/ld+json, application/atom+xml, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="alertsactivecountget"></a>
# **AlertsActiveCountGet**
> void AlertsActiveCountGet ()



Returns info on the number of active alerts

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AlertsActiveCountGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();

            try
            {
                apiInstance.AlertsActiveCountGet();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.AlertsActiveCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/ld+json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="alertsactiveget"></a>
# **AlertsActiveGet**
> void AlertsActiveGet (List<string> status = null, List<string> messageType = null, List<string> _event = null, List<string> code = null, string regionType = null, string point = null, List<string> region = null, List<string> area = null, List<string> zone = null, List<string> urgency = null, List<string> severity = null, List<string> certainty = null, int? limit = null)



Returns all currently active alerts

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AlertsActiveGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var status = new List<string>(); // List<string> | Status (actual, exercise, system, test, draft) (optional) 
            var messageType = new List<string>(); // List<string> | Message type (alert, update, cancel) (optional) 
            var _event = new List<string>(); // List<string> | Event name (optional) 
            var code = new List<string>(); // List<string> | Event code (optional) 
            var regionType = regionType_example;  // string | Region type (land or marine)  This parameter is incompatible with the following parameters: area, point, region, zone (optional) 
            var point = point_example;  // string | Point (latitude,longitude)  This parameter is incompatible with the following parameters: area, region, region_type, zone (optional) 
            var region = new List<string>(); // List<string> | Marine region code  This parameter is incompatible with the following parameters: area, point, region_type, zone (optional) 
            var area = new List<string>(); // List<string> | State/marine area code  This parameter is incompatible with the following parameters: point, region, region_type, zone (optional) 
            var zone = new List<string>(); // List<string> | Zone ID (forecast or county)  This parameter is incompatible with the following parameters: area, point, region, region_type (optional) 
            var urgency = new List<string>(); // List<string> | Urgency (immediate, expected, future, past, unknown) (optional) 
            var severity = new List<string>(); // List<string> | Severity (extreme, severe, moderate, minor, unknown) (optional) 
            var certainty = new List<string>(); // List<string> | Certainty (observed, likely, possible, unlikely, unknown) (optional) 
            var limit = 56;  // int? | Limit (optional) 

            try
            {
                apiInstance.AlertsActiveGet(status, messageType, _event, code, regionType, point, region, area, zone, urgency, severity, certainty, limit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.AlertsActiveGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **status** | [**List&lt;string&gt;**](string.md)| Status (actual, exercise, system, test, draft) | [optional] 
 **messageType** | [**List&lt;string&gt;**](string.md)| Message type (alert, update, cancel) | [optional] 
 **_event** | [**List&lt;string&gt;**](string.md)| Event name | [optional] 
 **code** | [**List&lt;string&gt;**](string.md)| Event code | [optional] 
 **regionType** | **string**| Region type (land or marine)  This parameter is incompatible with the following parameters: area, point, region, zone | [optional] 
 **point** | **string**| Point (latitude,longitude)  This parameter is incompatible with the following parameters: area, region, region_type, zone | [optional] 
 **region** | [**List&lt;string&gt;**](string.md)| Marine region code  This parameter is incompatible with the following parameters: area, point, region_type, zone | [optional] 
 **area** | [**List&lt;string&gt;**](string.md)| State/marine area code  This parameter is incompatible with the following parameters: point, region, region_type, zone | [optional] 
 **zone** | [**List&lt;string&gt;**](string.md)| Zone ID (forecast or county)  This parameter is incompatible with the following parameters: area, point, region, region_type | [optional] 
 **urgency** | [**List&lt;string&gt;**](string.md)| Urgency (immediate, expected, future, past, unknown) | [optional] 
 **severity** | [**List&lt;string&gt;**](string.md)| Severity (extreme, severe, moderate, minor, unknown) | [optional] 
 **certainty** | [**List&lt;string&gt;**](string.md)| Certainty (observed, likely, possible, unlikely, unknown) | [optional] 
 **limit** | **int?**| Limit | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/geo+json, application/ld+json, application/atom+xml, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="alertsactiveregionregionget"></a>
# **AlertsActiveRegionRegionGet**
> void AlertsActiveRegionRegionGet (string region)



Returns active alerts for the given marine region

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AlertsActiveRegionRegionGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var region = region_example;  // string | 

            try
            {
                apiInstance.AlertsActiveRegionRegionGet(region);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.AlertsActiveRegionRegionGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **region** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/geo+json, application/ld+json, application/atom+xml, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="alertsactivezonezoneidget"></a>
# **AlertsActiveZoneZoneIdGet**
> void AlertsActiveZoneZoneIdGet (string zoneId)



Returns active alerts for the given zone

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AlertsActiveZoneZoneIdGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var zoneId = zoneId_example;  // string | 

            try
            {
                apiInstance.AlertsActiveZoneZoneIdGet(zoneId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.AlertsActiveZoneZoneIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **zoneId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/geo+json, application/ld+json, application/atom+xml, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="alertsget"></a>
# **AlertsGet**
> void AlertsGet (bool? active = null, DateTime? start = null, DateTime? end = null, List<string> status = null, List<string> messageType = null, List<string> _event = null, List<string> code = null, string regionType = null, string point = null, List<string> region = null, List<string> area = null, List<string> zone = null, List<string> urgency = null, List<string> severity = null, List<string> certainty = null, int? limit = null, string cursor = null)



Returns all alerts

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AlertsGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var active = true;  // bool? | Active alerts (optional) 
            var start = 2013-10-20T19:20:30+01:00;  // DateTime? | Start time (optional) 
            var end = 2013-10-20T19:20:30+01:00;  // DateTime? | End time (optional) 
            var status = new List<string>(); // List<string> | Status (actual, exercise, system, test, draft) (optional) 
            var messageType = new List<string>(); // List<string> | Message type (alert, update, cancel) (optional) 
            var _event = new List<string>(); // List<string> | Event name (optional) 
            var code = new List<string>(); // List<string> | Event code (optional) 
            var regionType = regionType_example;  // string | Region type (land or marine)  This parameter is incompatible with the following parameters: area, point, region, zone (optional) 
            var point = point_example;  // string | Point (latitude,longitude)  This parameter is incompatible with the following parameters: area, region, region_type, zone (optional) 
            var region = new List<string>(); // List<string> | Marine region code  This parameter is incompatible with the following parameters: area, point, region_type, zone (optional) 
            var area = new List<string>(); // List<string> | State/marine area code  This parameter is incompatible with the following parameters: point, region, region_type, zone (optional) 
            var zone = new List<string>(); // List<string> | Zone ID (forecast or county)  This parameter is incompatible with the following parameters: area, point, region, region_type (optional) 
            var urgency = new List<string>(); // List<string> | Urgency (immediate, expected, future, past, unknown) (optional) 
            var severity = new List<string>(); // List<string> | Severity (extreme, severe, moderate, minor, unknown) (optional) 
            var certainty = new List<string>(); // List<string> | Certainty (observed, likely, possible, unlikely, unknown) (optional) 
            var limit = 56;  // int? | Limit (optional) 
            var cursor = cursor_example;  // string | Pagination cursor (optional) 

            try
            {
                apiInstance.AlertsGet(active, start, end, status, messageType, _event, code, regionType, point, region, area, zone, urgency, severity, certainty, limit, cursor);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.AlertsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **active** | **bool?**| Active alerts | [optional] 
 **start** | **DateTime?**| Start time | [optional] 
 **end** | **DateTime?**| End time | [optional] 
 **status** | [**List&lt;string&gt;**](string.md)| Status (actual, exercise, system, test, draft) | [optional] 
 **messageType** | [**List&lt;string&gt;**](string.md)| Message type (alert, update, cancel) | [optional] 
 **_event** | [**List&lt;string&gt;**](string.md)| Event name | [optional] 
 **code** | [**List&lt;string&gt;**](string.md)| Event code | [optional] 
 **regionType** | **string**| Region type (land or marine)  This parameter is incompatible with the following parameters: area, point, region, zone | [optional] 
 **point** | **string**| Point (latitude,longitude)  This parameter is incompatible with the following parameters: area, region, region_type, zone | [optional] 
 **region** | [**List&lt;string&gt;**](string.md)| Marine region code  This parameter is incompatible with the following parameters: area, point, region_type, zone | [optional] 
 **area** | [**List&lt;string&gt;**](string.md)| State/marine area code  This parameter is incompatible with the following parameters: point, region, region_type, zone | [optional] 
 **zone** | [**List&lt;string&gt;**](string.md)| Zone ID (forecast or county)  This parameter is incompatible with the following parameters: area, point, region, region_type | [optional] 
 **urgency** | [**List&lt;string&gt;**](string.md)| Urgency (immediate, expected, future, past, unknown) | [optional] 
 **severity** | [**List&lt;string&gt;**](string.md)| Severity (extreme, severe, moderate, minor, unknown) | [optional] 
 **certainty** | [**List&lt;string&gt;**](string.md)| Certainty (observed, likely, possible, unlikely, unknown) | [optional] 
 **limit** | **int?**| Limit | [optional] 
 **cursor** | **string**| Pagination cursor | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/geo+json, application/ld+json, application/atom+xml, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="alertsidget"></a>
# **AlertsIdGet**
> void AlertsIdGet (string id)



Returns a specific alert

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AlertsIdGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var id = id_example;  // string | 

            try
            {
                apiInstance.AlertsIdGet(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.AlertsIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/geo+json, application/ld+json, application/cap+xml, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="alertstypesget"></a>
# **AlertsTypesGet**
> void AlertsTypesGet ()



Returns a list of alert types

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AlertsTypesGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();

            try
            {
                apiInstance.AlertsTypesGet();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.AlertsTypesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/ld+json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="glossaryget"></a>
# **GlossaryGet**
> void GlossaryGet ()



Returns glossary terms

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GlossaryGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();

            try
            {
                apiInstance.GlossaryGet();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GlossaryGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/ld+json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="gridpointswfoxyforecastget"></a>
# **GridpointsWfoXyForecastGet**
> void GridpointsWfoXyForecastGet (string wfo, int? x, int? y, List<string> featureFlags = null, string units = null)



Returns a textual forecast for a 2.5km grid area

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GridpointsWfoXyForecastGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var wfo = wfo_example;  // string | 
            var x = 56;  // int? | 
            var y = 56;  // int? | 
            var featureFlags = new List<string>(); // List<string> | Enable future and experimental features (see documentation for more info):  * forecast_temperature_qv: Represent temperature as QuantitativeValue * forecast_wind_speed_qv: Represent wind speed as QuantitativeValue (optional) 
            var units = units_example;  // string | Use US customary or SI (metric) units in textual output (optional)  (default to us)

            try
            {
                apiInstance.GridpointsWfoXyForecastGet(wfo, x, y, featureFlags, units);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GridpointsWfoXyForecastGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **wfo** | **string**|  | 
 **x** | **int?**|  | 
 **y** | **int?**|  | 
 **featureFlags** | [**List&lt;string&gt;**](string.md)| Enable future and experimental features (see documentation for more info):  * forecast_temperature_qv: Represent temperature as QuantitativeValue * forecast_wind_speed_qv: Represent wind speed as QuantitativeValue | [optional] 
 **units** | **string**| Use US customary or SI (metric) units in textual output | [optional] [default to us]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/geo+json, application/ld+json, application/vnd.noaa.dwml+xml, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="gridpointswfoxyforecasthourlyget"></a>
# **GridpointsWfoXyForecastHourlyGet**
> void GridpointsWfoXyForecastHourlyGet (string wfo, int? x, int? y, List<string> featureFlags = null, string units = null)



Returns a textual hourly forecast for a 2.5km grid area

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GridpointsWfoXyForecastHourlyGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var wfo = wfo_example;  // string | 
            var x = 56;  // int? | 
            var y = 56;  // int? | 
            var featureFlags = new List<string>(); // List<string> | Enable future and experimental features (see documentation for more info):  * forecast_temperature_qv: Represent temperature as QuantitativeValue * forecast_wind_speed_qv: Represent wind speed as QuantitativeValue (optional) 
            var units = units_example;  // string | Use US customary or SI (metric) units in textual output (optional)  (default to us)

            try
            {
                apiInstance.GridpointsWfoXyForecastHourlyGet(wfo, x, y, featureFlags, units);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GridpointsWfoXyForecastHourlyGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **wfo** | **string**|  | 
 **x** | **int?**|  | 
 **y** | **int?**|  | 
 **featureFlags** | [**List&lt;string&gt;**](string.md)| Enable future and experimental features (see documentation for more info):  * forecast_temperature_qv: Represent temperature as QuantitativeValue * forecast_wind_speed_qv: Represent wind speed as QuantitativeValue | [optional] 
 **units** | **string**| Use US customary or SI (metric) units in textual output | [optional] [default to us]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/geo+json, application/ld+json, application/vnd.noaa.dwml+xml, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="gridpointswfoxyget"></a>
# **GridpointsWfoXyGet**
> void GridpointsWfoXyGet (string wfo, int? x, int? y)



Returns raw numerical forecast data for a 2.5km grid area

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GridpointsWfoXyGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var wfo = wfo_example;  // string | 
            var x = 56;  // int? | 
            var y = 56;  // int? | 

            try
            {
                apiInstance.GridpointsWfoXyGet(wfo, x, y);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GridpointsWfoXyGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **wfo** | **string**|  | 
 **x** | **int?**|  | 
 **y** | **int?**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/geo+json, application/ld+json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="gridpointswfoxystationsget"></a>
# **GridpointsWfoXyStationsGet**
> void GridpointsWfoXyStationsGet (string wfo, int? x, int? y)



Returns a list of observation stations usable for a given 2.5km grid area

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GridpointsWfoXyStationsGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var wfo = wfo_example;  // string | 
            var x = 56;  // int? | 
            var y = 56;  // int? | 

            try
            {
                apiInstance.GridpointsWfoXyStationsGet(wfo, x, y);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GridpointsWfoXyStationsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **wfo** | **string**|  | 
 **x** | **int?**|  | 
 **y** | **int?**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/geo+json, application/ld+json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="iconsget"></a>
# **IconsGet**
> void IconsGet ()



Returns a list of icon codes and textual descriptions

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class IconsGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();

            try
            {
                apiInstance.IconsGet();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.IconsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/ld+json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="iconssettimeofdayfirstsecondget"></a>
# **IconsSetTimeOfDayFirstSecondGet**
> void IconsSetTimeOfDayFirstSecondGet (string set, string timeOfDay, string first, string second, Size size = null, int? fontsize = null)



Returns a forecast icon

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class IconsSetTimeOfDayFirstSecondGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var set = set_example;  // string | 
            var timeOfDay = timeOfDay_example;  // string | 
            var first = first_example;  // string | 
            var second = second_example;  // string | 
            var size = new Size(); // Size | Font size (optional) 
            var fontsize = 56;  // int? | Font size (optional) 

            try
            {
                apiInstance.IconsSetTimeOfDayFirstSecondGet(set, timeOfDay, first, second, size, fontsize);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.IconsSetTimeOfDayFirstSecondGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **set** | **string**|  | 
 **timeOfDay** | **string**|  | 
 **first** | **string**|  | 
 **second** | **string**|  | 
 **size** | [**Size**](Size.md)| Font size | [optional] 
 **fontsize** | **int?**| Font size | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: image/png, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="officesofficeidget"></a>
# **OfficesOfficeIdGet**
> void OfficesOfficeIdGet (string officeId)



Returns metadata about a NWS forecast office

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OfficesOfficeIdGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var officeId = officeId_example;  // string | 

            try
            {
                apiInstance.OfficesOfficeIdGet(officeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.OfficesOfficeIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **officeId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/ld+json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="officesofficeidheadlinesget"></a>
# **OfficesOfficeIdHeadlinesGet**
> void OfficesOfficeIdHeadlinesGet (string officeId)



Returns a list of news headlines for a given NWS office

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OfficesOfficeIdHeadlinesGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var officeId = officeId_example;  // string | 

            try
            {
                apiInstance.OfficesOfficeIdHeadlinesGet(officeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.OfficesOfficeIdHeadlinesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **officeId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/ld+json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="officesofficeidheadlinesheadlineidget"></a>
# **OfficesOfficeIdHeadlinesHeadlineIdGet**
> void OfficesOfficeIdHeadlinesHeadlineIdGet (string officeId, string headlineId)



Returns a specific news headline for a given NWS office

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OfficesOfficeIdHeadlinesHeadlineIdGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var officeId = officeId_example;  // string | 
            var headlineId = headlineId_example;  // string | 

            try
            {
                apiInstance.OfficesOfficeIdHeadlinesHeadlineIdGet(officeId, headlineId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.OfficesOfficeIdHeadlinesHeadlineIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **officeId** | **string**|  | 
 **headlineId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/ld+json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="pointspointforecastget"></a>
# **PointsPointForecastGet**
> void PointsPointForecastGet (string point)



Returns a textual forecast for a given point

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PointsPointForecastGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var point = point_example;  // string | 

            try
            {
                apiInstance.PointsPointForecastGet(point);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.PointsPointForecastGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **point** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/geo+json, application/ld+json, application/vnd.noaa.dwml+xml, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="pointspointforecasthourlyget"></a>
# **PointsPointForecastHourlyGet**
> void PointsPointForecastHourlyGet (string point)



Returns a textual hourly forecast for a given point

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PointsPointForecastHourlyGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var point = point_example;  // string | 

            try
            {
                apiInstance.PointsPointForecastHourlyGet(point);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.PointsPointForecastHourlyGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **point** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/geo+json, application/ld+json, application/vnd.noaa.dwml+xml, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="pointspointget"></a>
# **PointsPointGet**
> void PointsPointGet (string point)



Returns metadata about a given latitude/longitude point

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PointsPointGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var point = point_example;  // string | 

            try
            {
                apiInstance.PointsPointGet(point);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.PointsPointGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **point** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/geo+json, application/ld+json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="pointspointstationsget"></a>
# **PointsPointStationsGet**
> void PointsPointStationsGet (string point)



Returns a list of observation stations for a given point

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PointsPointStationsGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var point = point_example;  // string | 

            try
            {
                apiInstance.PointsPointStationsGet(point);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.PointsPointStationsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **point** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/geo+json, application/ld+json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="productsget"></a>
# **ProductsGet**
> void ProductsGet (List<string> location = null, DateTime? start = null, DateTime? end = null, List<string> office = null, List<string> wmoid = null, List<string> type = null, int? limit = null)



Returns a list of text products

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ProductsGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var location = new List<string>(); // List<string> | Location id (optional) 
            var start = 2013-10-20T19:20:30+01:00;  // DateTime? | Start time (optional) 
            var end = 2013-10-20T19:20:30+01:00;  // DateTime? | End time (optional) 
            var office = new List<string>(); // List<string> | Issuing office (optional) 
            var wmoid = new List<string>(); // List<string> | WMO id code (optional) 
            var type = new List<string>(); // List<string> | Product code (optional) 
            var limit = 56;  // int? | Limit (optional) 

            try
            {
                apiInstance.ProductsGet(location, start, end, office, wmoid, type, limit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ProductsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **location** | [**List&lt;string&gt;**](string.md)| Location id | [optional] 
 **start** | **DateTime?**| Start time | [optional] 
 **end** | **DateTime?**| End time | [optional] 
 **office** | [**List&lt;string&gt;**](string.md)| Issuing office | [optional] 
 **wmoid** | [**List&lt;string&gt;**](string.md)| WMO id code | [optional] 
 **type** | [**List&lt;string&gt;**](string.md)| Product code | [optional] 
 **limit** | **int?**| Limit | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/ld+json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="productslocationsget"></a>
# **ProductsLocationsGet**
> void ProductsLocationsGet ()



Returns a list of valid text product issuance locations

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ProductsLocationsGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();

            try
            {
                apiInstance.ProductsLocationsGet();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ProductsLocationsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/ld+json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="productslocationslocationidtypesget"></a>
# **ProductsLocationsLocationIdTypesGet**
> void ProductsLocationsLocationIdTypesGet (string locationId)



Returns a list of valid text product types for a given issuance location

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ProductsLocationsLocationIdTypesGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var locationId = locationId_example;  // string | 

            try
            {
                apiInstance.ProductsLocationsLocationIdTypesGet(locationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ProductsLocationsLocationIdTypesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/ld+json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="productsproductidget"></a>
# **ProductsProductIdGet**
> void ProductsProductIdGet (string productId)



Returns a specific text product

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ProductsProductIdGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var productId = productId_example;  // string | 

            try
            {
                apiInstance.ProductsProductIdGet(productId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ProductsProductIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/ld+json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="productstypesget"></a>
# **ProductsTypesGet**
> void ProductsTypesGet ()



Returns a list of valid text product types and codes

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ProductsTypesGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();

            try
            {
                apiInstance.ProductsTypesGet();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ProductsTypesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/ld+json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="productstypestypeidget"></a>
# **ProductsTypesTypeIdGet**
> void ProductsTypesTypeIdGet (string typeId)



Returns a list of text products of a given type

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ProductsTypesTypeIdGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var typeId = typeId_example;  // string | 

            try
            {
                apiInstance.ProductsTypesTypeIdGet(typeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ProductsTypesTypeIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **typeId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/ld+json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="productstypestypeidlocationsget"></a>
# **ProductsTypesTypeIdLocationsGet**
> void ProductsTypesTypeIdLocationsGet (string typeId)



Returns a list of valid text product issuance locations for a given product type

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ProductsTypesTypeIdLocationsGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var typeId = typeId_example;  // string | 

            try
            {
                apiInstance.ProductsTypesTypeIdLocationsGet(typeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ProductsTypesTypeIdLocationsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **typeId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/ld+json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="productstypestypeidlocationslocationidget"></a>
# **ProductsTypesTypeIdLocationsLocationIdGet**
> void ProductsTypesTypeIdLocationsLocationIdGet (string typeId, string locationId)



Returns a list of text products of a given type for a given issuance location

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ProductsTypesTypeIdLocationsLocationIdGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var typeId = typeId_example;  // string | 
            var locationId = locationId_example;  // string | 

            try
            {
                apiInstance.ProductsTypesTypeIdLocationsLocationIdGet(typeId, locationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ProductsTypesTypeIdLocationsLocationIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **typeId** | **string**|  | 
 **locationId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/ld+json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="radarprofilersstationidget"></a>
# **RadarProfilersStationIdGet**
> void RadarProfilersStationIdGet (string stationId, string time = null, string interval = null)



Returns metadata about a given radar wind profiler

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RadarProfilersStationIdGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var stationId = stationId_example;  // string | 
            var time = time_example;  // string | Time interval (optional) 
            var interval = interval_example;  // string | Averaging interval (optional) 

            try
            {
                apiInstance.RadarProfilersStationIdGet(stationId, time, interval);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.RadarProfilersStationIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stationId** | **string**|  | 
 **time** | **string**| Time interval | [optional] 
 **interval** | **string**| Averaging interval | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/ld+json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="radarqueueshostget"></a>
# **RadarQueuesHostGet**
> void RadarQueuesHostGet (string host, int? limit = null, string arrived = null, string created = null, string published = null, string station = null, string type = null, string feed = null, int? resolution = null)



Returns metadata about a given radar queue

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RadarQueuesHostGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var host = host_example;  // string | 
            var limit = 56;  // int? | Record limit (optional) 
            var arrived = arrived_example;  // string | Range for arrival time (optional) 
            var created = created_example;  // string | Range for creation time (optional) 
            var published = published_example;  // string | Range for publish time (optional) 
            var station = station_example;  // string | Station identifier (optional) 
            var type = type_example;  // string | Record type (optional) 
            var feed = feed_example;  // string | Originating product feed (optional) 
            var resolution = 56;  // int? | Resolution version (optional) 

            try
            {
                apiInstance.RadarQueuesHostGet(host, limit, arrived, created, published, station, type, feed, resolution);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.RadarQueuesHostGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **host** | **string**|  | 
 **limit** | **int?**| Record limit | [optional] 
 **arrived** | **string**| Range for arrival time | [optional] 
 **created** | **string**| Range for creation time | [optional] 
 **published** | **string**| Range for publish time | [optional] 
 **station** | **string**| Station identifier | [optional] 
 **type** | **string**| Record type | [optional] 
 **feed** | **string**| Originating product feed | [optional] 
 **resolution** | **int?**| Resolution version | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/ld+json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="radarserversget"></a>
# **RadarServersGet**
> void RadarServersGet (string reportingHost = null)



Returns a list of radar servers

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RadarServersGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var reportingHost = reportingHost_example;  // string | Show records from specific reporting host (optional) 

            try
            {
                apiInstance.RadarServersGet(reportingHost);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.RadarServersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **reportingHost** | **string**| Show records from specific reporting host | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/ld+json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="radarserversidget"></a>
# **RadarServersIdGet**
> void RadarServersIdGet (string id, string reportingHost = null)



Returns metadata about a given radar server

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RadarServersIdGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var id = id_example;  // string | 
            var reportingHost = reportingHost_example;  // string | Show records from specific reporting host (optional) 

            try
            {
                apiInstance.RadarServersIdGet(id, reportingHost);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.RadarServersIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **reportingHost** | **string**| Show records from specific reporting host | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/ld+json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="radarstationsget"></a>
# **RadarStationsGet**
> void RadarStationsGet (List<string> stationType = null, string reportingHost = null, string host = null)



Returns a list of radar stations

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RadarStationsGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var stationType = new List<string>(); // List<string> | Limit results to a specific station type or types (optional) 
            var reportingHost = reportingHost_example;  // string | Show RDA and latency info from specific reporting host (optional) 
            var host = host_example;  // string | Show latency info from specific LDM host (optional) 

            try
            {
                apiInstance.RadarStationsGet(stationType, reportingHost, host);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.RadarStationsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stationType** | [**List&lt;string&gt;**](string.md)| Limit results to a specific station type or types | [optional] 
 **reportingHost** | **string**| Show RDA and latency info from specific reporting host | [optional] 
 **host** | **string**| Show latency info from specific LDM host | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/geo+json, application/ld+json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="radarstationsstationidalarmsget"></a>
# **RadarStationsStationIdAlarmsGet**
> void RadarStationsStationIdAlarmsGet (string stationId)



Returns metadata about a given radar station alarms

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RadarStationsStationIdAlarmsGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var stationId = stationId_example;  // string | 

            try
            {
                apiInstance.RadarStationsStationIdAlarmsGet(stationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.RadarStationsStationIdAlarmsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stationId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/ld+json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="radarstationsstationidget"></a>
# **RadarStationsStationIdGet**
> void RadarStationsStationIdGet (string stationId, string reportingHost = null, string host = null)



Returns metadata about a given radar station

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RadarStationsStationIdGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var stationId = stationId_example;  // string | 
            var reportingHost = reportingHost_example;  // string | Show RDA and latency info from specific reporting host (optional) 
            var host = host_example;  // string | Show latency info from specific LDM host (optional) 

            try
            {
                apiInstance.RadarStationsStationIdGet(stationId, reportingHost, host);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.RadarStationsStationIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stationId** | **string**|  | 
 **reportingHost** | **string**| Show RDA and latency info from specific reporting host | [optional] 
 **host** | **string**| Show latency info from specific LDM host | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/geo+json, application/ld+json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="stationsget"></a>
# **StationsGet**
> void StationsGet (List<string> id = null, List<string> state = null, int? limit = null)



Returns a list of observation stations

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StationsGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var id = new List<string>(); // List<string> | State abbreviation (optional) 
            var state = new List<string>(); // List<string> | State/marine area code (optional) 
            var limit = 56;  // int? | Limit (optional) 

            try
            {
                apiInstance.StationsGet(id, state, limit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.StationsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**List&lt;string&gt;**](string.md)| State abbreviation | [optional] 
 **state** | [**List&lt;string&gt;**](string.md)| State/marine area code | [optional] 
 **limit** | **int?**| Limit | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/geo+json, application/ld+json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="stationsstationidget"></a>
# **StationsStationIdGet**
> void StationsStationIdGet (string stationId)



Returns metadata about a given observation station

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StationsStationIdGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var stationId = stationId_example;  // string | 

            try
            {
                apiInstance.StationsStationIdGet(stationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.StationsStationIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stationId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/geo+json, application/ld+json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="stationsstationidobservationscurrentget"></a>
# **StationsStationIdObservationsCurrentGet**
> void StationsStationIdObservationsCurrentGet (string stationId, bool? requireQc = null)



Returns the latest observation for a station (use '/latest' instead)

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StationsStationIdObservationsCurrentGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var stationId = stationId_example;  // string | 
            var requireQc = true;  // bool? | Require QC (optional) 

            try
            {
                apiInstance.StationsStationIdObservationsCurrentGet(stationId, requireQc);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.StationsStationIdObservationsCurrentGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stationId** | **string**|  | 
 **requireQc** | **bool?**| Require QC | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/geo+json, application/ld+json, application/vnd.noaa.obs+xml, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="stationsstationidobservationsget"></a>
# **StationsStationIdObservationsGet**
> void StationsStationIdObservationsGet (string stationId, List<string> station = null, DateTime? start = null, DateTime? end = null, int? limit = null)



Returns a list of observations for a given station

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StationsStationIdObservationsGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var stationId = stationId_example;  // string | 
            var station = new List<string>(); // List<string> | Station ID (optional) 
            var start = 2013-10-20T19:20:30+01:00;  // DateTime? | Start date/time (optional) 
            var end = 2013-10-20T19:20:30+01:00;  // DateTime? | End date/time (optional) 
            var limit = 56;  // int? | Limit (optional) 

            try
            {
                apiInstance.StationsStationIdObservationsGet(stationId, station, start, end, limit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.StationsStationIdObservationsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stationId** | **string**|  | 
 **station** | [**List&lt;string&gt;**](string.md)| Station ID | [optional] 
 **start** | **DateTime?**| Start date/time | [optional] 
 **end** | **DateTime?**| End date/time | [optional] 
 **limit** | **int?**| Limit | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/geo+json, application/ld+json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="stationsstationidobservationslatestget"></a>
# **StationsStationIdObservationsLatestGet**
> void StationsStationIdObservationsLatestGet (string stationId, bool? requireQc = null)



Returns the latest observation for a station

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StationsStationIdObservationsLatestGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var stationId = stationId_example;  // string | 
            var requireQc = true;  // bool? | Require QC (optional) 

            try
            {
                apiInstance.StationsStationIdObservationsLatestGet(stationId, requireQc);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.StationsStationIdObservationsLatestGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stationId** | **string**|  | 
 **requireQc** | **bool?**| Require QC | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/geo+json, application/ld+json, application/vnd.noaa.obs+xml, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="stationsstationidobservationstimeget"></a>
# **StationsStationIdObservationsTimeGet**
> void StationsStationIdObservationsTimeGet (string stationId, DateTime? time)



Returns a single observation

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StationsStationIdObservationsTimeGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var stationId = stationId_example;  // string | 
            var time = 2013-10-20T19:20:30+01:00;  // DateTime? | 

            try
            {
                apiInstance.StationsStationIdObservationsTimeGet(stationId, time);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.StationsStationIdObservationsTimeGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stationId** | **string**|  | 
 **time** | **DateTime?**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/geo+json, application/ld+json, application/vnd.noaa.obs+xml, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="thumbnailssatelliteareaget"></a>
# **ThumbnailsSatelliteAreaGet**
> void ThumbnailsSatelliteAreaGet (string area)



Returns a thumbnail image for a satellite region

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ThumbnailsSatelliteAreaGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var area = area_example;  // string | 

            try
            {
                apiInstance.ThumbnailsSatelliteAreaGet(area);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ThumbnailsSatelliteAreaGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **area** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: image/jpeg, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="zonesforecastzoneidobservationsget"></a>
# **ZonesForecastZoneIdObservationsGet**
> void ZonesForecastZoneIdObservationsGet (string zoneId, DateTime? start = null, DateTime? end = null, int? limit = null)



Returns a list of observations for a given zone

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ZonesForecastZoneIdObservationsGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var zoneId = zoneId_example;  // string | 
            var start = 2013-10-20T19:20:30+01:00;  // DateTime? | Start date/time (optional) 
            var end = 2013-10-20T19:20:30+01:00;  // DateTime? | End date/time (optional) 
            var limit = 56;  // int? | Limit (optional) 

            try
            {
                apiInstance.ZonesForecastZoneIdObservationsGet(zoneId, start, end, limit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ZonesForecastZoneIdObservationsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **zoneId** | **string**|  | 
 **start** | **DateTime?**| Start date/time | [optional] 
 **end** | **DateTime?**| End date/time | [optional] 
 **limit** | **int?**| Limit | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/geo+json, application/ld+json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="zonesforecastzoneidstationsget"></a>
# **ZonesForecastZoneIdStationsGet**
> void ZonesForecastZoneIdStationsGet (string zoneId)



Returns a list of observation stations for a given zone

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ZonesForecastZoneIdStationsGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var zoneId = zoneId_example;  // string | 

            try
            {
                apiInstance.ZonesForecastZoneIdStationsGet(zoneId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ZonesForecastZoneIdStationsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **zoneId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/geo+json, application/ld+json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="zonesget"></a>
# **ZonesGet**
> void ZonesGet (List<string> id = null, List<string> area = null, List<string> region = null, List<string> type = null, string point = null, bool? includeGeometry = null, int? limit = null, DateTime? effective = null)



Returns a list of zones

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ZonesGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var id = new List<string>(); // List<string> | Zone ID (forecast or county) (optional) 
            var area = new List<string>(); // List<string> | State/marine area code (optional) 
            var region = new List<string>(); // List<string> | Region code (optional) 
            var type = new List<string>(); // List<string> | Zone type (optional) 
            var point = point_example;  // string | Point (latitude,longitude) (optional) 
            var includeGeometry = true;  // bool? | Include geometry in results (true/false) (optional) 
            var limit = 56;  // int? | Limit (optional) 
            var effective = 2013-10-20T19:20:30+01:00;  // DateTime? | Effective date/time (optional) 

            try
            {
                apiInstance.ZonesGet(id, area, region, type, point, includeGeometry, limit, effective);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ZonesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**List&lt;string&gt;**](string.md)| Zone ID (forecast or county) | [optional] 
 **area** | [**List&lt;string&gt;**](string.md)| State/marine area code | [optional] 
 **region** | [**List&lt;string&gt;**](string.md)| Region code | [optional] 
 **type** | [**List&lt;string&gt;**](string.md)| Zone type | [optional] 
 **point** | **string**| Point (latitude,longitude) | [optional] 
 **includeGeometry** | **bool?**| Include geometry in results (true/false) | [optional] 
 **limit** | **int?**| Limit | [optional] 
 **effective** | **DateTime?**| Effective date/time | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/geo+json, application/ld+json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="zonestypeget"></a>
# **ZonesTypeGet**
> void ZonesTypeGet (string type, List<string> id = null, List<string> area = null, List<string> region = null, List<string> type = null, string point = null, bool? includeGeometry = null, int? limit = null, DateTime? effective = null)



Returns a list of zones of a given type

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ZonesTypeGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var type = type_example;  // string | 
            var id = new List<string>(); // List<string> | Zone ID (forecast or county) (optional) 
            var area = new List<string>(); // List<string> | State/marine area code (optional) 
            var region = new List<string>(); // List<string> | Region code (optional) 
            var type = new List<string>(); // List<string> | Zone type (optional) 
            var point = point_example;  // string | Point (latitude,longitude) (optional) 
            var includeGeometry = true;  // bool? | Include geometry in results (true/false) (optional) 
            var limit = 56;  // int? | Limit (optional) 
            var effective = 2013-10-20T19:20:30+01:00;  // DateTime? | Effective date/time (optional) 

            try
            {
                apiInstance.ZonesTypeGet(type, id, area, region, type, point, includeGeometry, limit, effective);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ZonesTypeGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**|  | 
 **id** | [**List&lt;string&gt;**](string.md)| Zone ID (forecast or county) | [optional] 
 **area** | [**List&lt;string&gt;**](string.md)| State/marine area code | [optional] 
 **region** | [**List&lt;string&gt;**](string.md)| Region code | [optional] 
 **type** | [**List&lt;string&gt;**](string.md)| Zone type | [optional] 
 **point** | **string**| Point (latitude,longitude) | [optional] 
 **includeGeometry** | **bool?**| Include geometry in results (true/false) | [optional] 
 **limit** | **int?**| Limit | [optional] 
 **effective** | **DateTime?**| Effective date/time | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/geo+json, application/ld+json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="zonestypezoneidforecastget"></a>
# **ZonesTypeZoneIdForecastGet**
> void ZonesTypeZoneIdForecastGet (string type, string zoneId)



Returns the current zone forecast for a given zone

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ZonesTypeZoneIdForecastGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var type = type_example;  // string | 
            var zoneId = zoneId_example;  // string | 

            try
            {
                apiInstance.ZonesTypeZoneIdForecastGet(type, zoneId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ZonesTypeZoneIdForecastGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**|  | 
 **zoneId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/geo+json, application/ld+json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="zonestypezoneidget"></a>
# **ZonesTypeZoneIdGet**
> void ZonesTypeZoneIdGet (string type, string zoneId, DateTime? effective = null)



Returns metadata about a given zone

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ZonesTypeZoneIdGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var type = type_example;  // string | 
            var zoneId = zoneId_example;  // string | 
            var effective = 2013-10-20T19:20:30+01:00;  // DateTime? | Effective date/time (optional) 

            try
            {
                apiInstance.ZonesTypeZoneIdGet(type, zoneId, effective);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ZonesTypeZoneIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**|  | 
 **zoneId** | **string**|  | 
 **effective** | **DateTime?**| Effective date/time | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/geo+json, application/ld+json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
