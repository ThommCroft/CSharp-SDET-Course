using RestSharp;
using Newtonsoft.Json.Linq;
using WebAPITesting.HTTP_Manager;
using WebAPITesting.Data_Handling;

namespace WebAPITesting.Services
{
    public class PetServices
    {
        public CallManager CallManager { get; set; }

        public JObject Json_Response { get; set; }
        public DTO<Pet> PetDTOResponse { get; set; }
        public string Response { get; set; }

        public PetServices()
        {
            CallManager = new CallManager();
            PetDTOResponse = new DTO<Pet>();
        }

        public async Task MakeGetRequestAsync(string petID)
        {
            Response = await CallManager.MakeRequestAsync(petID, Resource.pet, Method.Get);
            Json_Response = JObject.Parse(Response);
            PetDTOResponse.DeserializeResponse(Response);
        }

        public async Task MakePostRequestAsync(string petID)
        {
            Response = await CallManager.MakeRequestAsync(petID, Resource.pet, Method.Post);
            Json_Response = JObject.Parse(Response);
            PetDTOResponse.DeserializeResponse(Response);
        }

        public async Task MakePutRequestAsync(string petID)
        {
            Response = await CallManager.MakeRequestAsync(petID, Resource.pet, Method.Put);
            Json_Response = JObject.Parse(Response);
            PetDTOResponse.DeserializeResponse(Response);
        }

        public async Task MakeDeleteRequestAsync(string petID)
        {
            Response = await CallManager.MakeRequestAsync(petID, Resource.pet, Method.Delete);
        }

        public int GetStatus()
        {
            return (int)CallManager.Response.StatusCode;
        }
    }
}
