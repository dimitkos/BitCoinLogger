using api.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
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


    }
}
