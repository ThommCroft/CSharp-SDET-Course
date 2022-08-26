using RestSharp;

namespace WebAPITesting.HTTP_Manager
{
    public class CallManager
    {
        private RestClient _client;

        private RestRequest _request;
        public RestResponse Response { get; set; }

        public CallManager()
        {
            _client = new RestClient(AppConfigReader.baseUrl);
            _request = new RestRequest();
            _request.AddHeader("Content-Type", "application/json");
        }

        public async Task<string> MakeRequestAsync(string id, Resource resource, Method method) // id, username, order, inventory
        {
            switch (resource)
            {
                case Resource.pet:
                    return await MakePetRequestAsync(id, resource, method);
                case Resource.store:
                    return await MakeStoreRequestAsync(id, resource, method);
                case Resource.user:
                    return await MakeUserRequestAsync(id, resource, method);
                default:
                    throw new ArgumentException();
            }
        }

        private async Task<string> MakePetRequestAsync(string id, Resource resource, Method method)
        {
            if (method == Method.Get)
            {
                _request.Resource = $"{resource}/{id}";
            }
            else if (method == Method.Post)
            {
                _request.Resource = $"{resource}";

                string[] newPet = id.Split(',');
                _request.AddJsonBody(new
                {
                    category = newPet[0],
                    name = newPet[1],
                    photoUrls = newPet[2],
                    tags = newPet[3],
                    status = newPet[4]
                });
            }
            else if (method == Method.Put)
            {
                _request.Resource = $"{resource}/{id}";

                string[] updatePet = id.Split(',');
                _request.AddJsonBody(new
                {
                    category = updatePet[0],
                    name = updatePet[1],
                    photoUrls = updatePet[2],
                    tags = updatePet[3],
                    status = updatePet[4]
                });
            }
            else if (method == Method.Delete)
            {
                _request.Resource = $"{resource}/{id}";
            }

            _request.Method = method;
            Response = await _client.ExecuteAsync(_request);
            return Response.Content;
        }

        private async Task<string> MakeStoreRequestAsync(string id, Resource resource, Method method)
        {
            if (method == Method.Get)
            {
                _request.Resource = $"{AppConfigReader.baseUrl}{resource}/{id}";
            }
            else if (method == Method.Post)
            {
                _request.Resource = $"{AppConfigReader.baseUrl}{resource}";

                string[] newOrder = id.Split(',');
                _request.AddJsonBody(new
                {
                    petId = newOrder[0],    //the array indexes may be wrong
                    quantity = newOrder[1],
                    shipDate = newOrder[2],
                    status = newOrder[3],
                    complete = newOrder[4],
                });
            }
            else if (method == Method.Delete)
            {
                _request.Resource = $"{AppConfigReader.baseUrl}{resource}/{id}";
            }

            _request.Method = method;
            Response = await _client.ExecuteAsync(_request);
            return Response.Content;
        }

        private async Task<string> MakeUserRequestAsync(string id, Resource resource, Method method)
        {
            if (method == Method.Get)
            {
                _request.Resource = $"{AppConfigReader.baseUrl}{resource}/{id}";
            }
            else if (method == Method.Post)
            {
                _request.Resource = $"{AppConfigReader.baseUrl}{resource}";

                string[] newUser = id.Split(',');
                _request.AddJsonBody(new
                {
                    username = newUser[0], // Same possible index issue as MakeStoreRequestAsync.
                    firstName = newUser[1],
                    lastName = newUser[2],
                    email = newUser[3],
                    password = newUser[4],
                    phone = newUser[5],
                    userStatus = newUser[6]
                });
            }
            else if (method == Method.Put)
            {
                _request.Resource = $"{AppConfigReader.baseUrl}{resource}/{id}";

                string[] updateUser = id.Split(',');
                _request.AddJsonBody(new
                {
                    username = updateUser[0], // Same possible index issue as MakeStoreRequestAsync.
                    firstName = updateUser[1],
                    lastName = updateUser[2],
                    email = updateUser[3],
                    password = updateUser[4],
                    phone = updateUser[5],
                    userStatus = updateUser[6]
                });
            }
            else if (method == Method.Delete)
            {
                _request.Resource = $"{AppConfigReader.baseUrl}{resource}/{id}";
            }

            _request.Method = method;
            Response = await _client.ExecuteAsync(_request);
            return Response.Content;
        }
    }
}
