using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ExternalApi.Types
{
    [DataContract]
    public class BitstampResponse
    {
        [DataMember(Name = "high")]
        public string High { get; set; }

        [DataMember(Name = "last")]
        public string Last { get; set; }

        [DataMember(Name = "timestamp")]
        public string Timestamp { get; set; }

        [DataMember(Name = "bid")]
        public string Bid { get; set; }

        [DataMember(Name = "vwap")]
        public string Vwap { get; set; }

        [DataMember(Name = "volume")]
        public string Volume { get; set; }

        [DataMember(Name = "low")]
        public string Low { get; set; }

        [DataMember(Name = "ask")]
        public string Ask { get; set; }

        [DataMember(Name = "open")]
        public double Open { get; set; }
    }
}
