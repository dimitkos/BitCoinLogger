﻿using ExternalApi.Interfaces;
using ExternalApi.Types;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExternalApi.Implementation
{
    public class BitstampImplementation : IBitstampService
    {
        public BitstampResponse GetDataFromBitstamp()
        {
            var client = new RestClient("https://www.bitstamp.net");
            var request = new RestRequest("/api/ticker/", Method.GET);
            var queryResult = client.Get<BitstampResponse>(request).Data;
            return queryResult;
        }
    }
}
