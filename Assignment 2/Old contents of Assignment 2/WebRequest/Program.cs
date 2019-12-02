using System;

namespace WebRequest
{

    using System;
    using System.Linq;
    using System.Net.Http;
    using System.Web;
    using System.Configuration;

    public class WebRequest
    {
        public static location[] findLocations(String CityName, String streetName, int addressNumber)
        {

            // Using HttpUtility to generate the parameters for the query string handles HTTP escaping the values.
            // Change these:
            var parameters = HttpUtility.ParseQueryString(string.Empty);
            parameters["where"] = $"MUNICIPALITY='{System.Configuration.Appse}' and STREETNAME='{streetName}' and ADDRESS_NUMBER='{addressNumber}'";
            parameters["outFields"] = "Latitude,longitude";
            parameters["f"] = "pjson";
            //parameters["resultRecordCount"] = "";

            //
            var address = @"https://gis.maine.gov/arcgis/rest/services/Location/Maine_E911_Addresses_Roads_PSAP/MapServer/1/query?"
                + parameters;

            // Disposing HttpClient is not best practice. It's good enough and I'm keeping this simple.
            using (var client = new HttpClient())
            {
                using (HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, address))
                {
                    // .Result from an Async function is not best practice. It's good enough and I'm keeping this simple.
                    var response = client.SendAsync(request).Result;
                    var content = response.Content.ReadAsStringAsync().Result;
                    if (!response.IsSuccessStatusCode)
                    {
                        throw new Exception($"{content}: {response.StatusCode}");
                    }

                    rootResponse root = Newtonsoft.Json.JsonConvert.DeserializeObject<rootResponse>(content);

                    return root.features.Select(f => f.attributes).ToArray(); // the content of the response
                }
            }
        }
    }

    public class rootResponse
    {
        public feature[] features;
    }
    public class feature
    {
        public location attributes;
    }
    public class location
    {
        public double Latitude;
        public double Longitude;
    }
    public class equation
    {
    
    }

}
