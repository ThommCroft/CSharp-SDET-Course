using JSONPlaceholderAPITesting.DataHandling;
using RestSharp;

namespace JSONPlaceholderAPITesting.HTTPManager
{
    public class CallManager
    {
        private readonly RestClient _client;
        private RestRequest _request;

        public RestResponse Response { get; set; }

        public CallManager()
        {
            _client = new RestClient(AppConfigReader.baseUrl);
            _request = new RestRequest();
            _request.AddHeader("Content-Type", "application/json");
        }

        public async Task<string> MakeRequestAsync(Resource resource, string content, Method method)
        {
            switch (resource)
            {
                case Resource.Posts:
                    return await MakePostRequestAsync(resource, content, method);
                case Resource.Users:
                    return await MakeUserRequestAsync(resource, content, method);
                default:
                    throw new ArgumentException();
            }
        }

        private async Task<string> MakePostRequestAsync(Resource resource, string content, Method method)
        {
            if (method == Method.Get)
            {
                _request.Resource = $"{resource}/{content}";
            }
            else if (method == Method.Post)
            {
                _request.Resource = $"{resource}";

                string[] newPost = content.Split(',');
                _request.AddJsonBody(new
                {
                    id = newPost[0],
                    userId = newPost[1],
                    title = newPost[2],
                    body = newPost[3]
                });
            }
            else if (method == Method.Put)
            {
                _request.Resource = $"{resource}/{content}";

                string[] newPost = content.Split(',');
                _request.AddJsonBody(new
                {
                    userId = newPost[0],
                    id = newPost[1],
                    title = newPost[2],
                    body = newPost[3]
                });
            }
            else if (method == Method.Delete)
            {
                _request.Resource = $"{resource}/{content}";
            }

            _request.Method = method;
            Response = await _client.ExecuteAsync(_request);
            return Response.Content;
        }

        private async Task<string> MakeUserRequestAsync(Resource resource, string content, Method method)
        {
            if (method == Method.Get)
            {
                _request.Resource = $"{resource}/{content}";
            }
            else if (method == Method.Post)
            {
                _request.Resource = $"{resource}";

                string[] newUser = content.Split(',');
                _request.AddJsonBody(new
                {
                    id = newUser[0],
                    name = newUser[1],
                    username = newUser[2],
                    email = newUser[3],
                    address = newUser[4],
                    phone = newUser[5],
                    website = newUser[6],
                    company = newUser[7]
                });
            }
            else if (method == Method.Put)
            {
                _request.Resource = $"{resource}/{content}";

                string[] updateUser = content.Split(',');
                _request.AddJsonBody(new
                {
                    id = updateUser[0],
                    name = updateUser[1],
                    username = updateUser[2],
                    email = updateUser[3],
                    address = updateUser[4],
                    phone = updateUser[5],
                    website = updateUser[6],
                    company = updateUser[7]
                });
            }
            else if (method == Method.Delete)
            {
                _request.Resource = $"{resource}/{content}";
            }

            _request.Method = method;
            Response = await _client.ExecuteAsync(_request);
            return Response.Content;
        }
    }
}
