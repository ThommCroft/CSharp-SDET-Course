using RestSharp;
using Newtonsoft.Json.Linq;
using JSONPlaceholderAPITesting.HTTPManager;
using JSONPlaceholderAPITesting.DataHandling;

namespace JSONPlaceholderAPITesting.Services
{
    public class UserService
    {
        public CallManager CallManager { get; set; }
        public JObject Json_Response { get; set; }
        public DTO<User> UserResponseDTO { get; set; }
        public string SelectedUser { get; set; }
        public string UserResponse { get; set; }

        public UserService()
        {
            CallManager = new CallManager();
            UserResponseDTO = new DTO<User>();
        }

        public async Task GetSingleUserRequestAsync(string userID)
        {
            SelectedUser = userID;
            UserResponse = await CallManager.MakeRequestAsync(Resource.Users, userID, Method.Get);
            Json_Response = JObject.Parse(UserResponse);
            UserResponseDTO.DeserializeResponse(UserResponse);
        }
    }
}
