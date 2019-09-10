using api.Interfaces;
using ExternalApi.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace api.Controllers
{
    public class BitcoinController : ApiController
    {
        private readonly IBitcoinLoggerService bitcoinLoggerService;

        public BitcoinController(IBitcoinLoggerService bitcoinLoggerService)
        {
            this.bitcoinLoggerService = bitcoinLoggerService;
        }

        [HttpGet]
        [ActionName("getGdaxData")]
        public HttpResponseMessage GetGdaxData()
        {
            var response = bitcoinLoggerService.FecthGdaxData();

            if (response != null)
            {
                return Request.CreateResponse<GdaxResponse>(HttpStatusCode.OK, response);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, " Data Not Found");
            }
        }
    }
}
