using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIClientApp.PostcodesIOService.DataHandling
{
    public class DataTransferObject<ResponseType> where ResponseType : IResponse, new()
    {
        // The class is the model of the Data returned by the API call
        public ResponseType Response { get; set; }

        public void DeserialiseResponse(string postcodeResponse)
        {
            Response = JsonConvert.DeserializeObject<ResponseType>(postcodeResponse);
        }
    }
}
