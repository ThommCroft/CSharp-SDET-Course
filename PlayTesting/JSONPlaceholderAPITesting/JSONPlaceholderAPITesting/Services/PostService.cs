using RestSharp;
using Newtonsoft.Json.Linq;
using JSONPlaceholderAPITesting.HTTPManager;
using JSONPlaceholderAPITesting.DataHandling;

namespace JSONPlaceholderAPITesting.Services
{
    public class PostService
    {
        public CallManager CallManager { get; set; }
        public JObject Json_Response { get; set; }
        public DTO<Post> PostResponseDTO { get; set; }
        public string SelectedPost { get; set; }
        public string PostResponse { get; set; }

        public PostService()
        {
            CallManager = new CallManager();
            PostResponseDTO = new DTO<Post>();
        }

        public async Task GetSinglePostRequestAsync(string postID)
        {
            SelectedPost = postID;
            PostResponse = await CallManager.MakeRequestAsync(Resource.Posts, postID, Method.Get);
            Json_Response = JObject.Parse(PostResponse);
            PostResponseDTO.DeserializeResponse(PostResponse);
        }

        public async Task CreateSinglePostRequestAsync(string postID)
        {
            SelectedPost = postID;
            PostResponse = await CallManager.MakeRequestAsync(Resource.Posts, postID, Method.Post);
            Json_Response = JObject.Parse(PostResponse);
            PostResponseDTO.DeserializeResponse(PostResponse);
        }

        public async Task UpdateSinglePostRequestAsync(string postID)
        {
            SelectedPost = postID;
            PostResponse = await CallManager.MakeRequestAsync(Resource.Posts, postID, Method.Put);
            Json_Response = JObject.Parse(PostResponse);
            PostResponseDTO.DeserializeResponse(PostResponse);
        }

        public async Task DeleteSinglePostRequestAsync(string postID)
        {
            //SelectedPost = postID;
            PostResponse = await CallManager.MakeRequestAsync(Resource.Posts, postID, Method.Delete);
            Json_Response = JObject.Parse(PostResponse);
            PostResponseDTO.DeserializeResponse(PostResponse);
        }
    }
}
