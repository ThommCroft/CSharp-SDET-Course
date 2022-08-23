using Newtonsoft.Json;

namespace WebAPITesting.Data_Handling
{
    public class DTO<ResponseType> where ResponseType : IResponse, new()
    {
        public ResponseType Response { get; set; }

        public void DeserializeResponse(string response)
        {
            Response = JsonConvert.DeserializeObject<ResponseType>(response);
        }
    }
}
