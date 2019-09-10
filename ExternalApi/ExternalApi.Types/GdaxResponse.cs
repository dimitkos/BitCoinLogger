using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ExternalApi.Types
{
    [DataContract]
    public class GdaxResponse
    {
        [DataMember(Name = "trade_id")]
        public int Trade_id { get; set; }

        [DataMember(Name = "price")]
        public string Price { get; set; }

        [DataMember(Name = "size")]
        public string Size { get; set; }

        [DataMember(Name = "time")]
        public DateTime Time { get; set; }

        [DataMember(Name = "bid")]
        public string Bid { get; set; }

        [DataMember(Name = "ask")]
        public string Ask { get; set; }

        [DataMember(Name = "volume")]
        public string Volume { get; set; }
    }
}
