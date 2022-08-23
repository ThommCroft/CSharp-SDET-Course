using Newtonsoft.Json.Linq;
using RestSharp;
using WebAPITesting.Data_Handling;
using WebAPITesting.HTTP_Manager;

namespace WebAPITesting.Services
{
    public class StoreServices
    {
        private CallManager _callManager;

        public JObject Json_Response { get; set; }
        public DTO<PetOrder> OrderDTOResponse { get; set; }
        public string Response { get; set; }

        public StoreServices()
        {
            _callManager = new CallManager();
            OrderDTOResponse = new DTO<PetOrder>();
        }

        public async Task MakeGetRequestAsync(string orderID)
        {
            Response = await _callManager.MakeRequestAsync(orderID, Resource.store, Method.Get);
            Json_Response = JObject.Parse(Response);
            OrderDTOResponse.DeserializeResponse(Response);
        }

        public async Task MakePostRequestAsync(string orderID)
        {
            Response = await _callManager.MakeRequestAsync(orderID, Resource.store, Method.Post);
            Json_Response = JObject.Parse(Response);
            OrderDTOResponse.DeserializeResponse(Response);
        }

        public async Task MakePutRequestAsync(string orderID)
        {
            Response = await _callManager.MakeRequestAsync(orderID, Resource.store, Method.Put);
            Json_Response = JObject.Parse(Response);
            OrderDTOResponse.DeserializeResponse(Response);
        }

        public async Task MakeDeleteRequestAsync(string orderID)
        {
            Response = await _callManager.MakeRequestAsync(orderID, Resource.store, Method.Delete);
        }

        public int GetStatus()
        {
            return (int)_callManager.Response.StatusCode;
        }
    }
}
