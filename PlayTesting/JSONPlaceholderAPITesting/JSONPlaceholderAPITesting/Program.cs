using RestSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JSONPlaceholderAPITesting
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            var restClient = new RestClient("https://jsonplaceholder.typicode.com/");
            var restRequest = new RestRequest();
            restRequest.Method = Method.Get;
            restRequest.AddHeader("Content-Type", "application/json");

            restRequest.Resource = "posts";

            RestResponse allPosts = await restClient.ExecuteAsync(restRequest);

            Console.WriteLine((int)allPosts.StatusCode);
            Console.WriteLine();
            Console.WriteLine(allPosts.Content);
        }
    }
}