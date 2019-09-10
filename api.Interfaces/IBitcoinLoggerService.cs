using ExternalApi.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api.Interfaces
{
    public interface IBitcoinLoggerService
    {
        BitstampResponse FecthBitstampData();

        GdaxResponse FecthGdaxData();
    }
}
