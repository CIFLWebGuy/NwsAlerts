using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;

namespace NwsAlertApi
{
    /// <summary>
    /// Defines the properties and methods used to access the NWS Alert API.
    /// </summary>
    public class ApiClient
    {
        private JsonSerializerOptions jsonOptions;
        private static List<string> areaList;

        /// <summary>
        /// Gets the user agent identifier.
        /// </summary>
        public string UserAgent { get; }

        /// <summary>
        /// Gets the API endpoint.
        /// </summary>
        public string Endpoint { get; }

        /// <summary>
        /// Initalizes an instance of the ApiClient class with the specified User-Agent string.
        /// </summary>
        /// <param name="endpoint">The API endpoint URL.</param>
        /// <param name="userAgent">The User-Agent string use to authenticate the API</param>
        /// <exception cref="ArgumentNullException"><paramref name="endpoint"/> or <paramref name="userAgent"/> are null or empty.</exception>
        public ApiClient(string endpoint, string userAgent)
        {
            if(string.IsNullOrEmpty(userAgent))
            {
                throw new ArgumentException("User Agent string must be provided.");
            }

            if(string.IsNullOrEmpty(endpoint))
            {
                throw new ArgumentNullException("API endpoint must be provided.");
            }

            UserAgent = userAgent;
            Endpoint = endpoint;

            jsonOptions = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
        }

        /// <summary>
        /// Gets the list of event types used by the NWS.
        /// </summary>
        /// <returns>A list of strings that contains the event types.</returns>
        public List<string> GetEventTypes()
        {
            var client = new RestClient(Endpoint);
            var request = InitalizeRequest("alerts/types");
            var response = client.Execute(request);

            if (response.StatusCode != HttpStatusCode.OK)
            {
                ApiError error = JsonSerializer.Deserialize<ApiError>(response.Content);

                throw new HttpListenerException(error.Status, error.Message);
            }

            NwsEventTypes events = JsonSerializer.Deserialize<NwsEventTypes>(response.Content, jsonOptions);

            return events.EventTypes.ToList();
        }

        /// <summary>
        /// Gets the list of available state and territory codes.
        /// </summary>
        /// <returns></returns>
        public List<string> GetStates()
        {
            if (areaList == null)
            {
                areaList = new List<string>();

                using (StreamReader reader = new StreamReader("AreaList.dat"))
                {
                    while (!reader.EndOfStream)
                    {
                        areaList.Add(reader.ReadLine());
                    }

                    reader.Close();
                }
            }

            return areaList;
        }

        /// <summary>
        /// Returns the alerts specified by the <paramref name="filter"/> parameter.
        /// </summary>
        /// <param name="filter">The parameters used to specify the alerts to retrieve.</param>
        /// <returns>List of <see cref="Alert" /> objects that contain the alerts specified. </returns>
        /// <exception cref="ArgumentNullException">The <paramref name="filter"/> parameter is null.</exception>
        public AlertResponse GetAlerts(AlertFilters filter)
        {
            if (filter == null)
            {
                throw new ArgumentNullException("alertParams");
            }

            var client = new RestClient(Endpoint);
            var request = InitalizeRequest("alerts");

            if (filter.Active != null)
                request.AddParameter("active", filter.Active.Value.ToString().ToLower());

            if (filter.Start != null)
                request.AddParameter("start", filter.Start.Value);

            if (filter.End != null)
                request.AddParameter("end", filter.End.Value);

            if (filter.Status != AlertStatuses.None)
                request.AddParameter("status", GetEnumFlagString(filter.Status));

            if (filter.MessageTypes != MessageTypes.None)
                request.AddParameter("message_type", GetEnumFlagString(filter.MessageTypes));

            if (filter.Events.Count > 0)
                request.AddParameter("event", PackList(filter.Events));

            if (filter.Codes.Count > 0)
                request.AddParameter("code", PackList(filter.Codes));

            Tuple<string, string> area = GetGeographicArea(filter.Area);

            if (area != null)
                request.AddParameter(area.Item1, area.Item2);

            if (filter.Urgency != Urgencies.None)
                request.AddParameter("urgency", GetEnumFlagString(filter.Urgency));

            if (filter.Limit > 0)
                request.AddParameter("limit", filter.Limit);

            if (filter.PageNo != null)
                request.AddParameter("cursor", filter.PageNo.Value);

            var response = client.Execute(request);

            if(response.StatusCode != HttpStatusCode.OK)
            {
                ApiError error = JsonSerializer.Deserialize<ApiError>(response.Content, jsonOptions);

                throw new ApiException(error);
            }

            return JsonSerializer.Deserialize<AlertResponse>(response.Content, jsonOptions);
        }

        /// <summary>
        /// Gets the zones for the specified area.
        /// </summary>
        /// <param name="area">The geographic area </param>
        /// <param name="includeGeo">Determines if geographic data is returned back.</param>
        /// <param name="effective">The effective date of the zones.</param>
        /// <returns>A list of <see cref="Zone"/> objects that contains the zones in the specified area.</returns>
        public List<Zone> GetZones(GeographicArea area, bool includeGeo, DateTime effective)
        {
            return GetZones(area, includeGeo, effective, 0);
        }

        /// <summary>
        /// Gets the zones for the specified area.
        /// </summary>
        /// <param name="area">The geographic area </param>
        /// <param name="includeGeo">Determines if geographic data is returned back.</param>
        /// <returns>A list of <see cref="Zone"/> objects that contains the zones in the specified area.</returns>
        public List<Zone> GetZones(GeographicArea area, bool includeGeo)
        {
            return GetZones(area, includeGeo, DateTime.MinValue, 0);
        }

        /// <summary>
        /// Gets the zones for the specified area.
        /// </summary>
        /// <param name="area">The geographic area </param>
        /// <param name="includeGeo">Determines if geographic data is returned back.</param>
        /// <param name="limit">The maximum nuber of zones to retrieve.</param>
        /// <returns>A list of <see cref="Zone"/> objects that contains the zones in the specified area.</returns>
        /// <returns></returns>
        public List<Zone> GetZones(GeographicArea area, bool includeGeo, int limit)
        {
            return GetZones(area, includeGeo, DateTime.MinValue, limit);
        }

        /// <summary>
        /// Gets the zones for the specified area.
        /// </summary>
        /// <param name="area">The geographic area </param>
        /// <param name="includeGeo">Determines if geographic data is returned back.</param>
        /// <param name="effective">The effective date of the zones.</param>
        /// <param name="limit">The maximum nuber of zones to retrieve.</param>
        /// <returns>A list of <see cref="Zone"/> objects that contains the zones in the specified area.</returns>
        public List<Zone> GetZones(GeographicArea area, bool includeGeo, DateTime effective, int limit)
        {
            var client = new RestClient(Endpoint);
            var request = InitalizeRequest("zones");

            Tuple<string, string> areaParam = GetGeographicArea(area);

            request.AddParameter(areaParam.Item1, areaParam.Item2);
            request.AddParameter("include_geometry", includeGeo ? "true" : "false");

            if (limit > 0)
                request.AddParameter("limit", limit);

            if (effective != DateTime.MinValue)
                request.AddParameter("effective", effective);

            var response = client.Execute(request);

            if (response.StatusCode != HttpStatusCode.OK)
                throw new ApiException(JsonSerializer.Deserialize<ApiError>(response.Content, jsonOptions));

            ZoneResponse zoneData = JsonSerializer.Deserialize<ZoneResponse>(response.Content, jsonOptions);

            return zoneData.Zones;
        }

        /// <summary>
        /// Gets information about the specified office.
        /// </summary>
        /// <param name="officeID"></param>
        /// <returns>An <see cref="NwsOffice"/> object that contains the office information.</returns>
        public NwsOffice GetOffice(string officeID)
        {
            var client = new RestClient(Endpoint);
            var request = InitalizeRequest($"offices/{officeID}");            
            var response = client.Execute(request);

            if (response.StatusCode != HttpStatusCode.OK)
                throw new ApiException(JsonSerializer.Deserialize<ApiError>(response.Content, jsonOptions));

            NwsOffice office = JsonSerializer.Deserialize<NwsOffice>(response.Content, jsonOptions);

            return office;
        }

        /// <summary>
        /// Returns the value of the geographic area used.
        /// </summary>
        /// <param name="area">The <see cref="GeographicArea"/> object used to specify an area.</param>
        /// <returns>A <see cref="Tuple"/> object with two items. Item1: param name, Item2: value</returns>
        private Tuple<string, string> GetGeographicArea(GeographicArea area)
        {
            if (area == null)
                return null;

            if (area.RegionType != RegionType.None)
                return new Tuple<string, string>("region_type", GetEnumFlagString(area.RegionType));

            if (area.Point != null)
                return new Tuple<string, string>("point", $"{area.Point.Value.X},{area.Point.Value.Y}");

            if (area.Region != Regions.None)
                return new Tuple<string, string>("region", GetEnumFlagString(area.Region));

            if (area.StateCodes.Count > 0)
                return new Tuple<string, string>("area", PackList(area.StateCodes.ToList()));

            if (area.Zones.Count > 0)
                return new Tuple<string, string>("zone", PackList(area.Zones.ToList()));

            return null;
        }

        /// <summary>
        /// Converts an enum flag value into a query string array.
        /// </summary>
        /// <param name="e">The enum value to convert.</param>
        /// <returns>The value formatted as a comma-delimited string.</returns>
        private string GetEnumFlagString(Enum e)
        {
            return e.ToString().ToLower().Replace(" ", "");
        }

        /// <summary>
        /// Packs the items in a list into a comma-delimited list.
        /// </summary>
        /// <param name="items">The list of items</param>
        /// <returns></returns>
        private string PackList(List<string> items)
        {
            StringBuilder sb = new StringBuilder();

            foreach (string item in items)
            {
                if (sb.Length > 0)
                    sb.Append(",");

                sb.Append(item);
            }

            return sb.ToString();
        }

        private RestRequest InitalizeRequest(string endpoint)
        {
            var request = new RestRequest(endpoint, Method.GET);
            request.AddHeader("User-Agent", UserAgent);
            request.AddHeader("Accept", "application/ld+json");


            return request;
        }
    }
}
