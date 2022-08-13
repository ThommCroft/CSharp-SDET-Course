using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIClientApp.PostcodesIOService.HTTPManager
{
    public class CallManager
    {
        //RestSharp object which handles comms with the API
        private readonly RestClient _client;

        #region Properties
        // Captures the response
        public RestResponse Response { get; set; }
        #endregion

        public CallManager()
        {
            _client = new RestClient(AppConfigReader.BaseUrl);
        }

        //Method that defines and makes the API request and storse the response
        public async Task<string> MakePostcodeRequestAsync(string resource, string postcode) // adding a string resource Parameter will make this method useable for outcodes (enum)
        {
            // Make Request
            var request = new RestRequest();
            request.AddHeader("Content-Type", "application/json");
            request.Resource = $"{resource}/{postcode.ToLower().Replace(" ", "")}";

            // Execute Request
            Response = await _client.ExecuteAsync(request);

            return Response.Content;
        }
    }
}
