using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace APIClientApp
{
    public class SinglePostcodeService
    {
        #region Properties
        public RestClient Client { get; set; } // RestSharp object which handles comms with the API
        public RestResponse Response { get; set; } // Captures the response
        public JObject ResponseContent { get; set; } // Capture the response body JSON
        public SinglePostcodeResponse ResponseObject { get; set; }
        #endregion

        public SinglePostcodeService()
        {
            Client = new RestClient(AppConfigReader.BaseUrl);
        }

        public async Task MakeRequestAsync(string postcode)
        {
            // Set up Request
            var request = new RestRequest();
            request.AddHeader("Content-Type", "application/json");
            request.Resource = $"postcodes/{postcode.ToLower().Replace(" ", "")}";

            // Make Request
            Response = await Client.ExecuteAsync(request);

            // Parse JSON body to ResponseContent
            ResponseContent = JObject.Parse(Response.Content);

            // An object model of the response
            //ResponseObject = JsonConvert.DeserializeObject<SinglePostcodeResponse>(Response.Content);
        }

        public int GetStatusCode()
        {
            return (int)Response.StatusCode;
        }
    }
}
