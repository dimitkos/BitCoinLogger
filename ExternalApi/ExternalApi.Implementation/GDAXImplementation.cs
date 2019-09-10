using ExternalApi.Interfaces;
using ExternalApi.Types;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExternalApi.Implementation
{
    public class GDAXImplementation : IGDAXService
    {
        public GdaxResponse GetDataFromGdax()
        {
            var client = new RestClient("https://api.gdax.com");
            var request = new RestRequest("/products/BTC-USD/ticker", Method.GET);
            var queryResult = client.Get<GdaxResponse>(request).Data;
            return queryResult;
        }
    }
}
