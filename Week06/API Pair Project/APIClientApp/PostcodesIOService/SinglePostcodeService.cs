using APIClientApp.PostcodesIOService.DataHandling;
using APIClientApp.PostcodesIOService.HTTPManager;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace APIClientApp.PostcodesIOService
{
    public class SinglePostcodeService
    {
        // In the mini projects README, add a section that tells people how to create a response?

        #region Properties
        public CallManager CallManager { get; set; }

        //Capture the response body JSON
        public JObject JsonResponse { get; set; }

        public DataTransferObject<SinglePostcodeResponse> SinglePostcodeDTO { get; set; }
        public string PostcodeResponse { get; set; }
        #endregion

        public SinglePostcodeService()
        {
            CallManager = new CallManager();
            SinglePostcodeDTO = new DataTransferObject<SinglePostcodeResponse>();
        }

        /// <summary>
        /// Defines and makes the API request, and Stores the response.
        /// </summary>
        /// <param name="postcode"></param>
        /// <returns></returns>
        public async Task MakesRequestAsync(string postcode)
        {
            PostcodeResponse = await CallManager.MakePostcodeRequestAsync("postcodes", postcode);
            JsonResponse = JObject.Parse(PostcodeResponse);

            //Use DTO to convert JSON string to an object tree
            SinglePostcodeDTO.DeserialiseResponse(PostcodeResponse);
        }

        public int GetStatus()
        {
            return (int)CallManager.Response.StatusCode;
        }

        public int GetSinglePostcodeDTOStatus()
        {
            return (int)SinglePostcodeDTO.Response.status;
        }

        public int CodeCount()
        {
            return JsonResponse["result"]["codes"].Count();
        }

        public string GetAdminDistrict()
        {
            return SinglePostcodeDTO.Response.result.admin_district;
        }

        public string GetContentType()
        {
            return CallManager.Response.ContentType;
        }

        public Dictionary<string, object> GetHeaders()
        {
            Dictionary<string, object> headers = new Dictionary<string, object>();

            foreach (var header in CallManager.Response.Headers)
            {
                headers.Add(header.Name, header.Value);
            }

            return headers;
        }
    }
}
