using Newtonsoft.Json.Linq;
using RestSharp;
using WebAPITesting.Data_Handling;
using WebAPITesting.HTTP_Manager;

namespace WebAPITesting.Services
{
    public class UserServices
    {
        // There are 3 Post Methods, Create 1 User, Create a List of Users, Create an Array of Users
        // The List and Array methods will need to loop through the number of added user. (Maybe)
        private CallManager _callManager;

        public JObject Json_Response { get; set; }
        public DTO<StoreUser> UserDTOResponse { get; set; }
        public string Response { get; set; }

        public UserServices()
        {
            _callManager = new CallManager();
            UserDTOResponse = new DTO<StoreUser>();
        }

        public async Task MakeGetRequestAsync(string username)
        {
            Response = await _callManager.MakeRequestAsync(username, Resource.user, Method.Get);
            Json_Response = JObject.Parse(Response);
            UserDTOResponse.DeserializeResponse(Response);
        }

        public async Task MakePostRequestAsync(string username)
        {
            Response = await _callManager.MakeRequestAsync(username, Resource.user, Method.Post);
            Json_Response = JObject.Parse(Response);
            UserDTOResponse.DeserializeResponse(Response);
        }

        public async Task MakePutRequestAsync(string username)
        {
            Response = await _callManager.MakeRequestAsync(username, Resource.user, Method.Put);
            Json_Response = JObject.Parse(Response);
            UserDTOResponse.DeserializeResponse(Response);
        }

        public async Task MakeDeleteRequestAsync(string username)
        {
            Response = await _callManager.MakeRequestAsync(username, Resource.user, Method.Delete);
        }

        public int GetStatus()
        {
            return (int)_callManager.Response.StatusCode;
        }
    }
}
