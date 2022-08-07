using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace APIClientApp
{
    public class Program
    {
        static async Task Main(string[] args) //https://api.postcodes.io
        {
            #region Example 01
            // Encapsulate the information we need to make the API call
            // We can make authenticated HTTP requests
            //var restClient = new RestClient("https://api.postcodes.io/");

            //// Set up the request. Create a request object
            //var restRequest = new RestRequest();
            //restRequest.Method = Method.Get;
            //restRequest.AddHeader("Content-Type", "application/json");

            //var postCode = "EC2Y 5AS";
            //restRequest.Resource = $"postcodes/{postCode.ToLower().Replace(" ", "")}";

            //// Execute Request
            //var singlePostcodeResponse = await restClient.ExecuteAsync(restRequest);

            //Console.WriteLine("Response Content (string)");
            //Console.WriteLine(singlePostcodeResponse.Content);

            //Console.WriteLine("Response Status Code (Enum)");
            //Console.WriteLine(singlePostcodeResponse.StatusCode);

            //Console.WriteLine("Response Status Code (int)");
            //Console.WriteLine((int)singlePostcodeResponse.StatusCode);

            //Console.WriteLine("Response Status (Enum)");
            //Console.WriteLine(singlePostcodeResponse.ResponseStatus);

            //Console.WriteLine("Response Status (int)");
            //Console.WriteLine((int)singlePostcodeResponse.ResponseStatus);

            //Console.WriteLine();

            //foreach (var item in singlePostcodeResponse.Headers)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine();

            //var responseContentType = singlePostcodeResponse.Headers.Where(x => x.Name == "Date").Select(h => h.Value.ToString()).FirstOrDefault();

            //Console.WriteLine(responseContentType);

            //Console.WriteLine();

            #endregion

            #region Example 02
            //var client = new RestClient();
            //var request = new RestRequest("https://api.postcodes.io/postcodes/", Method.Post);
            //request.AddStringBody("{\r\n\"postcodes\" : [\"OX49 5NU\", \"M32 0JG\", \"NE30 1DP\"]\r\n}\r\n", DataFormat.Json);

            //var postCodes = new
            //{
            //    postCodes = new string[] { "PR3 0SG", "M45 6GN", "EX165BL" }
            //};

            //request.AddJsonBody(postCodes);

            //var singlePostcodeJsonResponse = JObject.Parse(singlePostcodeResponse.Content);
            //Console.WriteLine(singlePostcodeJsonResponse);

            //var adminDistrict = singlePostcodeJsonResponse["result"]["admin_district"];
            //Console.WriteLine(adminDistrict);
            //Console.WriteLine();

            //Console.WriteLine("Bulk Postcode"); // repeat what we have just done but with Bulk Postcode

            //RestResponse bulkResponse = await client.ExecuteAsync(request);
            //var bulkPostcodeJsonResponse = JObject.Parse(bulkResponse.Content);

            ////Console.WriteLine(bulkPostcodeJsonResponse);

            ////foreach (var item in bulkPostcodeJsonResponse["result"])
            ////{
            ////    Console.WriteLine(item["result"]["nhs_ha"]);
            ////}

            //Console.WriteLine();

            //Console.WriteLine("Query: " + bulkPostcodeJsonResponse["result"][0]["query"]);
            //Console.WriteLine("Admin County: " + bulkPostcodeJsonResponse["result"][0]["result"]["codes"]["admin_county"]);

            ////var singlePostcodeObjectResponse = JsonConvert.DeserializeObject<SinglePostcodeResponse>(singlePostcodeResponse.Content);
            //var bulkPostcodeObjectResponse = JsonConvert.DeserializeObject<BulkPostcodeResponse>(bulkResponse.Content);

            //Console.WriteLine("Bulk Response\n");

            //foreach (var p in bulkPostcodeObjectResponse.result)
            //{
            //    Console.WriteLine(p.query);
            //    Console.WriteLine($"{p.postcode.admin_ward}\n");
            //}

            //Console.WriteLine();
            #endregion


            //await OutCodesActivityAsync("LN1");
        }

        private static async Task OutCodesActivityAsync(string outCode) // repeat what we have just done but with Bulk Postcode
        {
            var client = new RestClient();
            var request = new RestRequest($"https://api.postcodes.io/outcodes/{outCode.Trim()}", Method.Get);

            RestResponse outResponse = await client.ExecuteAsync(request);

            var outcodesJsonResponse = JObject.Parse(outResponse.Content);
            Console.WriteLine(outcodesJsonResponse.ToString());
            Console.WriteLine();

            var outcodeObjectResponse = JsonConvert.DeserializeObject<OutCode>(outResponse.Content);
            Console.WriteLine(outcodeObjectResponse.result.admin_county[0]);

            //foreach (var item in outcodeObjectResponse["result"][""])
            //{

            //}
        }
    }
}