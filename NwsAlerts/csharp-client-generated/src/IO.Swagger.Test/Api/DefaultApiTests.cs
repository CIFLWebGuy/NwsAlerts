/* 
 * weather.gov API
 *
 * weather.gov API
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing DefaultApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class DefaultApiTests
    {
        private DefaultApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DefaultApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DefaultApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' DefaultApi
            //Assert.IsInstanceOfType(typeof(DefaultApi), instance, "instance is a DefaultApi");
        }

        /// <summary>
        /// Test AlertsActiveAreaAreaGet
        /// </summary>
        [Test]
        public void AlertsActiveAreaAreaGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string area = null;
            //instance.AlertsActiveAreaAreaGet(area);
            
        }
        /// <summary>
        /// Test AlertsActiveCountGet
        /// </summary>
        [Test]
        public void AlertsActiveCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.AlertsActiveCountGet();
            
        }
        /// <summary>
        /// Test AlertsActiveGet
        /// </summary>
        [Test]
        public void AlertsActiveGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string> status = null;
            //List<string> messageType = null;
            //List<string> _event = null;
            //List<string> code = null;
            //string regionType = null;
            //string point = null;
            //List<string> region = null;
            //List<string> area = null;
            //List<string> zone = null;
            //List<string> urgency = null;
            //List<string> severity = null;
            //List<string> certainty = null;
            //int? limit = null;
            //instance.AlertsActiveGet(status, messageType, _event, code, regionType, point, region, area, zone, urgency, severity, certainty, limit);
            
        }
        /// <summary>
        /// Test AlertsActiveRegionRegionGet
        /// </summary>
        [Test]
        public void AlertsActiveRegionRegionGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string region = null;
            //instance.AlertsActiveRegionRegionGet(region);
            
        }
        /// <summary>
        /// Test AlertsActiveZoneZoneIdGet
        /// </summary>
        [Test]
        public void AlertsActiveZoneZoneIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string zoneId = null;
            //instance.AlertsActiveZoneZoneIdGet(zoneId);
            
        }
        /// <summary>
        /// Test AlertsGet
        /// </summary>
        [Test]
        public void AlertsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? active = null;
            //DateTime? start = null;
            //DateTime? end = null;
            //List<string> status = null;
            //List<string> messageType = null;
            //List<string> _event = null;
            //List<string> code = null;
            //string regionType = null;
            //string point = null;
            //List<string> region = null;
            //List<string> area = null;
            //List<string> zone = null;
            //List<string> urgency = null;
            //List<string> severity = null;
            //List<string> certainty = null;
            //int? limit = null;
            //string cursor = null;
            //instance.AlertsGet(active, start, end, status, messageType, _event, code, regionType, point, region, area, zone, urgency, severity, certainty, limit, cursor);
            
        }
        /// <summary>
        /// Test AlertsIdGet
        /// </summary>
        [Test]
        public void AlertsIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.AlertsIdGet(id);
            
        }
        /// <summary>
        /// Test AlertsTypesGet
        /// </summary>
        [Test]
        public void AlertsTypesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.AlertsTypesGet();
            
        }
        /// <summary>
        /// Test GlossaryGet
        /// </summary>
        [Test]
        public void GlossaryGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.GlossaryGet();
            
        }
        /// <summary>
        /// Test GridpointsWfoXyForecastGet
        /// </summary>
        [Test]
        public void GridpointsWfoXyForecastGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string wfo = null;
            //int? x = null;
            //int? y = null;
            //List<string> featureFlags = null;
            //string units = null;
            //instance.GridpointsWfoXyForecastGet(wfo, x, y, featureFlags, units);
            
        }
        /// <summary>
        /// Test GridpointsWfoXyForecastHourlyGet
        /// </summary>
        [Test]
        public void GridpointsWfoXyForecastHourlyGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string wfo = null;
            //int? x = null;
            //int? y = null;
            //List<string> featureFlags = null;
            //string units = null;
            //instance.GridpointsWfoXyForecastHourlyGet(wfo, x, y, featureFlags, units);
            
        }
        /// <summary>
        /// Test GridpointsWfoXyGet
        /// </summary>
        [Test]
        public void GridpointsWfoXyGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string wfo = null;
            //int? x = null;
            //int? y = null;
            //instance.GridpointsWfoXyGet(wfo, x, y);
            
        }
        /// <summary>
        /// Test GridpointsWfoXyStationsGet
        /// </summary>
        [Test]
        public void GridpointsWfoXyStationsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string wfo = null;
            //int? x = null;
            //int? y = null;
            //instance.GridpointsWfoXyStationsGet(wfo, x, y);
            
        }
        /// <summary>
        /// Test IconsGet
        /// </summary>
        [Test]
        public void IconsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.IconsGet();
            
        }
        /// <summary>
        /// Test IconsSetTimeOfDayFirstSecondGet
        /// </summary>
        [Test]
        public void IconsSetTimeOfDayFirstSecondGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string set = null;
            //string timeOfDay = null;
            //string first = null;
            //string second = null;
            //Size size = null;
            //int? fontsize = null;
            //instance.IconsSetTimeOfDayFirstSecondGet(set, timeOfDay, first, second, size, fontsize);
            
        }
        /// <summary>
        /// Test OfficesOfficeIdGet
        /// </summary>
        [Test]
        public void OfficesOfficeIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string officeId = null;
            //instance.OfficesOfficeIdGet(officeId);
            
        }
        /// <summary>
        /// Test OfficesOfficeIdHeadlinesGet
        /// </summary>
        [Test]
        public void OfficesOfficeIdHeadlinesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string officeId = null;
            //instance.OfficesOfficeIdHeadlinesGet(officeId);
            
        }
        /// <summary>
        /// Test OfficesOfficeIdHeadlinesHeadlineIdGet
        /// </summary>
        [Test]
        public void OfficesOfficeIdHeadlinesHeadlineIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string officeId = null;
            //string headlineId = null;
            //instance.OfficesOfficeIdHeadlinesHeadlineIdGet(officeId, headlineId);
            
        }
        /// <summary>
        /// Test PointsPointForecastGet
        /// </summary>
        [Test]
        public void PointsPointForecastGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string point = null;
            //instance.PointsPointForecastGet(point);
            
        }
        /// <summary>
        /// Test PointsPointForecastHourlyGet
        /// </summary>
        [Test]
        public void PointsPointForecastHourlyGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string point = null;
            //instance.PointsPointForecastHourlyGet(point);
            
        }
        /// <summary>
        /// Test PointsPointGet
        /// </summary>
        [Test]
        public void PointsPointGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string point = null;
            //instance.PointsPointGet(point);
            
        }
        /// <summary>
        /// Test PointsPointStationsGet
        /// </summary>
        [Test]
        public void PointsPointStationsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string point = null;
            //instance.PointsPointStationsGet(point);
            
        }
        /// <summary>
        /// Test ProductsGet
        /// </summary>
        [Test]
        public void ProductsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string> location = null;
            //DateTime? start = null;
            //DateTime? end = null;
            //List<string> office = null;
            //List<string> wmoid = null;
            //List<string> type = null;
            //int? limit = null;
            //instance.ProductsGet(location, start, end, office, wmoid, type, limit);
            
        }
        /// <summary>
        /// Test ProductsLocationsGet
        /// </summary>
        [Test]
        public void ProductsLocationsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.ProductsLocationsGet();
            
        }
        /// <summary>
        /// Test ProductsLocationsLocationIdTypesGet
        /// </summary>
        [Test]
        public void ProductsLocationsLocationIdTypesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string locationId = null;
            //instance.ProductsLocationsLocationIdTypesGet(locationId);
            
        }
        /// <summary>
        /// Test ProductsProductIdGet
        /// </summary>
        [Test]
        public void ProductsProductIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string productId = null;
            //instance.ProductsProductIdGet(productId);
            
        }
        /// <summary>
        /// Test ProductsTypesGet
        /// </summary>
        [Test]
        public void ProductsTypesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.ProductsTypesGet();
            
        }
        /// <summary>
        /// Test ProductsTypesTypeIdGet
        /// </summary>
        [Test]
        public void ProductsTypesTypeIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string typeId = null;
            //instance.ProductsTypesTypeIdGet(typeId);
            
        }
        /// <summary>
        /// Test ProductsTypesTypeIdLocationsGet
        /// </summary>
        [Test]
        public void ProductsTypesTypeIdLocationsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string typeId = null;
            //instance.ProductsTypesTypeIdLocationsGet(typeId);
            
        }
        /// <summary>
        /// Test ProductsTypesTypeIdLocationsLocationIdGet
        /// </summary>
        [Test]
        public void ProductsTypesTypeIdLocationsLocationIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string typeId = null;
            //string locationId = null;
            //instance.ProductsTypesTypeIdLocationsLocationIdGet(typeId, locationId);
            
        }
        /// <summary>
        /// Test RadarProfilersStationIdGet
        /// </summary>
        [Test]
        public void RadarProfilersStationIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string stationId = null;
            //string time = null;
            //string interval = null;
            //instance.RadarProfilersStationIdGet(stationId, time, interval);
            
        }
        /// <summary>
        /// Test RadarQueuesHostGet
        /// </summary>
        [Test]
        public void RadarQueuesHostGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string host = null;
            //int? limit = null;
            //string arrived = null;
            //string created = null;
            //string published = null;
            //string station = null;
            //string type = null;
            //string feed = null;
            //int? resolution = null;
            //instance.RadarQueuesHostGet(host, limit, arrived, created, published, station, type, feed, resolution);
            
        }
        /// <summary>
        /// Test RadarServersGet
        /// </summary>
        [Test]
        public void RadarServersGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string reportingHost = null;
            //instance.RadarServersGet(reportingHost);
            
        }
        /// <summary>
        /// Test RadarServersIdGet
        /// </summary>
        [Test]
        public void RadarServersIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string reportingHost = null;
            //instance.RadarServersIdGet(id, reportingHost);
            
        }
        /// <summary>
        /// Test RadarStationsGet
        /// </summary>
        [Test]
        public void RadarStationsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string> stationType = null;
            //string reportingHost = null;
            //string host = null;
            //instance.RadarStationsGet(stationType, reportingHost, host);
            
        }
        /// <summary>
        /// Test RadarStationsStationIdAlarmsGet
        /// </summary>
        [Test]
        public void RadarStationsStationIdAlarmsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string stationId = null;
            //instance.RadarStationsStationIdAlarmsGet(stationId);
            
        }
        /// <summary>
        /// Test RadarStationsStationIdGet
        /// </summary>
        [Test]
        public void RadarStationsStationIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string stationId = null;
            //string reportingHost = null;
            //string host = null;
            //instance.RadarStationsStationIdGet(stationId, reportingHost, host);
            
        }
        /// <summary>
        /// Test StationsGet
        /// </summary>
        [Test]
        public void StationsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string> id = null;
            //List<string> state = null;
            //int? limit = null;
            //instance.StationsGet(id, state, limit);
            
        }
        /// <summary>
        /// Test StationsStationIdGet
        /// </summary>
        [Test]
        public void StationsStationIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string stationId = null;
            //instance.StationsStationIdGet(stationId);
            
        }
        /// <summary>
        /// Test StationsStationIdObservationsCurrentGet
        /// </summary>
        [Test]
        public void StationsStationIdObservationsCurrentGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string stationId = null;
            //bool? requireQc = null;
            //instance.StationsStationIdObservationsCurrentGet(stationId, requireQc);
            
        }
        /// <summary>
        /// Test StationsStationIdObservationsGet
        /// </summary>
        [Test]
        public void StationsStationIdObservationsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string stationId = null;
            //List<string> station = null;
            //DateTime? start = null;
            //DateTime? end = null;
            //int? limit = null;
            //instance.StationsStationIdObservationsGet(stationId, station, start, end, limit);
            
        }
        /// <summary>
        /// Test StationsStationIdObservationsLatestGet
        /// </summary>
        [Test]
        public void StationsStationIdObservationsLatestGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string stationId = null;
            //bool? requireQc = null;
            //instance.StationsStationIdObservationsLatestGet(stationId, requireQc);
            
        }
        /// <summary>
        /// Test StationsStationIdObservationsTimeGet
        /// </summary>
        [Test]
        public void StationsStationIdObservationsTimeGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string stationId = null;
            //DateTime? time = null;
            //instance.StationsStationIdObservationsTimeGet(stationId, time);
            
        }
        /// <summary>
        /// Test ThumbnailsSatelliteAreaGet
        /// </summary>
        [Test]
        public void ThumbnailsSatelliteAreaGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string area = null;
            //instance.ThumbnailsSatelliteAreaGet(area);
            
        }
        /// <summary>
        /// Test ZonesForecastZoneIdObservationsGet
        /// </summary>
        [Test]
        public void ZonesForecastZoneIdObservationsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string zoneId = null;
            //DateTime? start = null;
            //DateTime? end = null;
            //int? limit = null;
            //instance.ZonesForecastZoneIdObservationsGet(zoneId, start, end, limit);
            
        }
        /// <summary>
        /// Test ZonesForecastZoneIdStationsGet
        /// </summary>
        [Test]
        public void ZonesForecastZoneIdStationsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string zoneId = null;
            //instance.ZonesForecastZoneIdStationsGet(zoneId);
            
        }
        /// <summary>
        /// Test ZonesGet
        /// </summary>
        [Test]
        public void ZonesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string> id = null;
            //List<string> area = null;
            //List<string> region = null;
            //List<string> type = null;
            //string point = null;
            //bool? includeGeometry = null;
            //int? limit = null;
            //DateTime? effective = null;
            //instance.ZonesGet(id, area, region, type, point, includeGeometry, limit, effective);
            
        }
        /// <summary>
        /// Test ZonesTypeGet
        /// </summary>
        [Test]
        public void ZonesTypeGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string type = null;
            //List<string> id = null;
            //List<string> area = null;
            //List<string> region = null;
            //List<string> type = null;
            //string point = null;
            //bool? includeGeometry = null;
            //int? limit = null;
            //DateTime? effective = null;
            //instance.ZonesTypeGet(type, id, area, region, type, point, includeGeometry, limit, effective);
            
        }
        /// <summary>
        /// Test ZonesTypeZoneIdForecastGet
        /// </summary>
        [Test]
        public void ZonesTypeZoneIdForecastGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string type = null;
            //string zoneId = null;
            //instance.ZonesTypeZoneIdForecastGet(type, zoneId);
            
        }
        /// <summary>
        /// Test ZonesTypeZoneIdGet
        /// </summary>
        [Test]
        public void ZonesTypeZoneIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string type = null;
            //string zoneId = null;
            //DateTime? effective = null;
            //instance.ZonesTypeZoneIdGet(type, zoneId, effective);
            
        }
    }

}
