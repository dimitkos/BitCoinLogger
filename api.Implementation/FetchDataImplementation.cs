using api.Interfaces;
using ExternalApi.Interfaces;
using ExternalApi.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api.Implementation
{
    public class FetchDataImplementation : IBitcoinLoggerService
    {
        private readonly IBitstampService bitstampService;
        private readonly IGDAXService gdaxService;

        public FetchDataImplementation(IBitstampService bitstampService, IGDAXService gdaxService)
        {
            this.bitstampService = bitstampService;
            this.gdaxService = gdaxService;
        }

        public BitstampResponse FecthBitstampData()
        {
            return bitstampService.GetDataFromBitstamp();
        }

        public GdaxResponse FecthGdaxData()
        {
            return gdaxService.GetDataFromGdax();
        }
    }
}
